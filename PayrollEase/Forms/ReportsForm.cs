using System;
using System.Data;
using System.Windows.Forms;

namespace PayrollEase
{
    public partial class ReportsForm : Form, IRefreshable
    {
        DataTable data;
        bool loading;
        bool statusHooked;

        public ReportsForm()
        {
            InitializeComponent();
            DateTime t = DateTime.Today;
            dtpFrom.Value = new DateTime(t.Year, t.Month, 1);
            dtpTo.Value = t;
            loading = true;
            cmbReport.SelectedIndex = 0;
            loading = false;
            ApplyReportChoice();
        }

        public void RefreshData()
        {
            LoadPeriods();
            Generate();
        }

        private void LoadPeriods()
        {
            loading = true;
            try
            {
                int keep = Ui.SelectedId(cmbPeriod);
                DataTable dt = red_framework.AppDb.Instance.TableData(
                    "SELECT Id, CONVERT(NVARCHAR(12), PeriodStart, 107) + N'  -  ' + CONVERT(NVARCHAR(12), PeriodEnd, 107) AS Label " +
                    "FROM PayrollPeriods ORDER BY PeriodEnd DESC");
                Ui.FillCombo(cmbPeriod, dt, "Label", "Id");
                if (keep > 0) cmbPeriod.SelectedValue = keep;
                if (cmbPeriod.SelectedIndex < 0 && cmbPeriod.Items.Count > 0) cmbPeriod.SelectedIndex = 0;
            }
            finally
            {
                loading = false;
            }
        }

        private void ApplyReportChoice()
        {
            int i = cmbReport.SelectedIndex;
            bool dates = i == 1 || i == 2;
            bool period = i == 3 || i == 4;
            lblFrom.Visible = dates;
            dtpFrom.Visible = dates;
            lblTo.Visible = dates;
            dtpTo.Visible = dates;
            lblPeriod.Visible = period;
            cmbPeriod.Visible = period;
        }

        private void cmbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            ApplyReportChoice();
            Generate();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private static void AddTotals(DataTable dt, string labelColumn, params string[] sumColumns)
        {
            if (dt.Rows.Count == 0) return;
            DataRow total = dt.NewRow();
            total[labelColumn] = "TOTAL";
            foreach (string col in sumColumns)
            {
                decimal sum = 0m;
                foreach (DataRow r in dt.Rows) sum += Fmt.D(r[col]);
                total[col] = sum;
            }
            dt.Rows.Add(total);
        }

        private void Generate()
        {
            if (loading) return;
            int choice = cmbReport.SelectedIndex;
            if ((choice == 1 || choice == 2) && dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                Ui.Warn("The start date must be on or before the end date.");
                return;
            }

            string info = "";
            data = null;
            switch (choice)
            {
                case 0:
                    data = red_framework.AppDb.Instance.TableData(
                        "SELECT EmployeeNo AS [ID], LastName + N', ' + FirstName AS Employee, Position, Department, PayType AS [Pay Type], Rate, Allowance, " +
                        "DateHired AS [Date Hired], ContactNumber AS Contact, CASE WHEN IsActive = 1 THEN N'Active' ELSE N'Inactive' END AS Status " +
                        "FROM Employees ORDER BY LastName, FirstName");
                    info = data.Rows.Count + " employees";
                    break;

                case 1:
                    data = red_framework.AppDb.Instance.TableData(
                        "SELECT e.EmployeeNo AS [ID], e.LastName + N', ' + e.FirstName AS Employee, " +
                        "SUM(CASE WHEN a.Status IN (N'Present', N'Late') THEN 1 ELSE 0 END) AS [Days Present], " +
                        "SUM(CASE WHEN a.Status = N'Late' THEN 1 ELSE 0 END) AS [Times Late], " +
                        "SUM(CASE WHEN a.Status = N'Half Day' THEN 1 ELSE 0 END) AS [Half Days], " +
                        "SUM(CASE WHEN a.Status = N'Absent' THEN 1 ELSE 0 END) AS Absences, " +
                        "SUM(CASE WHEN a.Status = N'Leave' THEN 1 ELSE 0 END) AS Leaves, " +
                        "ISNULL(SUM(a.HoursWorked), 0) AS Hours, ISNULL(SUM(a.OvertimeHours), 0) AS [OT Hours], " +
                        "ISNULL(SUM(a.LateMinutes), 0) AS [Late Min], ISNULL(SUM(a.UndertimeMinutes), 0) AS [Undertime Min] " +
                        "FROM Employees e LEFT JOIN Attendance a ON a.EmployeeId = e.Id AND a.WorkDate BETWEEN @f AND @t " +
                        "WHERE e.IsActive = 1 GROUP BY e.Id, e.EmployeeNo, e.LastName, e.FirstName ORDER BY e.LastName, e.FirstName",
                        new { f = dtpFrom.Value.Date, t = dtpTo.Value.Date });
                    info = Fmt.Period(dtpFrom.Value.Date, dtpTo.Value.Date) + "  |  " + data.Rows.Count + " active employees";
                    break;

                case 2:
                    data = red_framework.AppDb.Instance.TableData(
                        "SELECT a.WorkDate AS [Date], e.EmployeeNo AS [ID], e.LastName + N', ' + e.FirstName AS Employee, a.TimeIn AS [Time In], a.TimeOut AS [Time Out], " +
                        "a.HoursWorked AS Hours, a.LateMinutes AS [Late Min], a.UndertimeMinutes AS [Undertime Min], a.OvertimeHours AS [OT Hours], a.Status, a.Remarks " +
                        "FROM Attendance a INNER JOIN Employees e ON e.Id = a.EmployeeId WHERE a.WorkDate BETWEEN @f AND @t " +
                        "ORDER BY a.WorkDate, e.LastName, e.FirstName",
                        new { f = dtpFrom.Value.Date, t = dtpTo.Value.Date });
                    info = Fmt.Period(dtpFrom.Value.Date, dtpTo.Value.Date) + "  |  " + data.Rows.Count + " records";
                    break;

                default:
                    int pid = Ui.SelectedId(cmbPeriod);
                    if (pid <= 0)
                    {
                        data = new DataTable();
                        info = "No saved payroll yet. Save a payroll first.";
                        break;
                    }
                    if (choice == 3)
                    {
                        data = red_framework.AppDb.Instance.TableData(
                            "SELECT e.EmployeeNo AS [ID], e.LastName + N', ' + e.FirstName AS Employee, p.DaysPaid AS Days, p.BasicPay AS [Basic Pay], " +
                            "p.OvertimePay AS [OT Pay], p.Allowance, p.OtherEarnings AS [Other Earn], p.GrossPay AS [Gross Pay], p.LateDeduction AS [Late/UT], " +
                            "p.SSS, p.PhilHealth, p.PagIbig AS [Pag-IBIG], p.Tax, p.OtherDeductions AS [Other Ded], p.TotalDeductions AS [Total Ded], p.NetPay AS [Net Pay] " +
                            "FROM Payslips p INNER JOIN Employees e ON e.Id = p.EmployeeId WHERE p.PeriodId = @pid ORDER BY e.LastName, e.FirstName",
                            new { pid = pid });
                        AddTotals(data, "Employee", "Basic Pay", "OT Pay", "Allowance", "Other Earn", "Gross Pay", "Late/UT",
                            "SSS", "PhilHealth", "Pag-IBIG", "Tax", "Other Ded", "Total Ded", "Net Pay");
                    }
                    else
                    {
                        data = red_framework.AppDb.Instance.TableData(
                            "SELECT e.EmployeeNo AS [ID], e.LastName + N', ' + e.FirstName AS Employee, e.SSSNo AS [SSS No], e.PhilHealthNo AS [PhilHealth No], " +
                            "e.PagIbigNo AS [Pag-IBIG No], e.TIN, p.SSS, p.PhilHealth, p.PagIbig AS [Pag-IBIG], p.Tax AS [Withholding Tax], " +
                            "(p.SSS + p.PhilHealth + p.PagIbig + p.Tax) AS Total " +
                            "FROM Payslips p INNER JOIN Employees e ON e.Id = p.EmployeeId WHERE p.PeriodId = @pid ORDER BY e.LastName, e.FirstName",
                            new { pid = pid });
                        AddTotals(data, "Employee", "SSS", "PhilHealth", "Pag-IBIG", "Withholding Tax", "Total");
                    }
                    info = "Payroll period: " + cmbPeriod.Text.Replace("  -  ", " - ") + "  |  employee share only";
                    break;
            }

            lblInfo.Text = info;
            dgvReport.DataSource = data;
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn c in dgvReport.Columns)
            {
                Type ty = data != null && data.Columns.Contains(c.Name) ? data.Columns[c.Name].DataType : typeof(string);
                if (ty == typeof(decimal) || ty == typeof(int))
                {
                    c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    if (ty == typeof(decimal)) c.DefaultCellStyle.Format = "N2";
                }
                else if (ty == typeof(DateTime))
                {
                    c.DefaultCellStyle.Format = (c.Name == "Time In" || c.Name == "Time Out") ? "hh:mm tt" : "MMM dd, yyyy";
                }
            }
            if (!statusHooked)
            {
                Ui.ColorStatus(dgvReport, "Status");
                statusHooked = true;
            }
            dgvReport.ClearSelection();
        }

        private DataTable PrintTable()
        {
            if (data == null || data.Rows.Count == 0)
            {
                Ui.Info("Generate a report with data first.");
                return null;
            }
            return Ui.ToPrintTable(data);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DataTable pt = PrintTable();
            if (pt == null) return;
            red_framework.ReportPrinter.Preview(pt, AppSettings.Company + " - " + cmbReport.Text, lblInfo.Text);
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            DataTable pt = PrintTable();
            if (pt == null) return;
            string name = "report_" + DateTime.Today.ToString("yyyyMMdd", Fmt.Ci);
            if (CsvExporter.Save(pt, name)) Ui.Info("Report exported.");
        }
    }
}
