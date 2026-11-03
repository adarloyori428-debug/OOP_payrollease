using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollEase
{
    public partial class PayrollForm : Form, IRefreshable
    {
        Database db = new Database();
        List<PayLine> lines = new List<PayLine>();
        int savedPeriodId;
        DateTime curStart, curEnd, curPay;
        bool loading;
        bool statusHooked;

        public PayrollForm()
        {
            InitializeComponent();
            dgvPayroll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DateTime today = DateTime.Today;
            SetHalf(today.Day <= 15 ? 1 : 2, today);
            cmbAdjType.SelectedIndex = 0;
            dtpAdjDate.Value = today;
            loading = true;
            dtpAdjFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpAdjTo.Value = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
            loading = false;
            btnSavePayroll.Enabled = false;
            ShowTotals();
        }

        public void RefreshData()
        {
            LoadHistory();
            int sel = Ui.SelectedId(cmbAdjEmployee);
            Ui.FillCombo(cmbAdjEmployee, Ui.EmployeeTable(false, true), "Name", "Id");
            if (sel > 0) cmbAdjEmployee.SelectedValue = sel;
            LoadAdjustments();
        }

        // ---------- period buttons ----------
        private void SetHalf(int half, DateTime reference)
        {
            int y = reference.Year, m = reference.Month;
            DateTime s, e;
            if (half == 1)
            {
                s = new DateTime(y, m, 1);
                e = new DateTime(y, m, 15);
            }
            else
            {
                s = new DateTime(y, m, 16);
                e = new DateTime(y, m, DateTime.DaysInMonth(y, m));
            }
            dtpStart.Value = s;
            dtpEnd.Value = e;
            dtpPayDate.Value = e;
        }

        private void btnFirstHalf_Click(object sender, EventArgs e) { SetHalf(1, dtpStart.Value); }
        private void btnSecondHalf_Click(object sender, EventArgs e) { SetHalf(2, dtpStart.Value); }

        // ---------- computing ----------
        private void btnCompute_Click(object sender, EventArgs e)
        {
            DateTime s = dtpStart.Value.Date;
            DateTime en = dtpEnd.Value.Date;
            if (s > en) { Ui.Warn("The period start must be on or before the period end."); return; }
            if ((en - s).TotalDays > 62) { Ui.Warn("A pay period cannot be longer than 62 days."); return; }

            int existing = PayrollEngine.FindPeriodId(s, en);
            if (existing > 0)
            {
                if (Ui.Confirm("A payroll for " + Fmt.Period(s, en) + " has already been saved.\n\nOpen the saved payroll instead?"))
                    OpenPeriod(existing);
                return;
            }

            Cursor = Cursors.WaitCursor;
            try { lines = PayrollEngine.Compute(s, en); }
            finally { Cursor = Cursors.Default; }

            if (lines.Count == 0)
            {
                Ui.Info("There are no active employees yet. Add employees first.");
                BindGrid();
                return;
            }

            savedPeriodId = 0;
            curStart = s;
            curEnd = en;
            curPay = dtpPayDate.Value.Date;
            BindGrid();
            btnSavePayroll.Enabled = true;

            int incomplete = 0, negative = 0;
            foreach (PayLine l in lines)
            {
                incomplete += l.Incomplete;
                if (l.NetPay < 0m) negative++;
            }
            string msg = "Preview for " + Fmt.Period(s, en) + " - not saved yet.";
            if (incomplete > 0) msg += "  " + incomplete + " record(s) have a time in but no time out.";
            if (negative > 0) msg += "  " + negative + " employee(s) have negative net pay.";
            lblMode.Text = msg;
            lblMode.ForeColor = (incomplete > 0 || negative > 0) ? Theme.RedDark : Theme.TealDark;
        }

        private void btnSavePayroll_Click(object sender, EventArgs e)
        {
            if (savedPeriodId > 0 || lines.Count == 0) return;
            if (PayrollEngine.FindPeriodId(curStart, curEnd) > 0)
            {
                Ui.Warn("A payroll for this period was already saved.");
                return;
            }
            if (!Ui.Confirm("Save the payroll for " + Fmt.Period(curStart, curEnd) + "?\n\nThis finalizes " + lines.Count + " payslips.")) return;

            bool ok;
            Cursor = Cursors.WaitCursor;
            try { ok = PayrollEngine.SavePeriod(curStart, curEnd, curPay, lines, Session.Username); }
            finally { Cursor = Cursors.Default; }

            if (!ok)
            {
                Ui.Error("The payroll could not be saved. No changes were made.");
                return;
            }

            savedPeriodId = PayrollEngine.FindPeriodId(curStart, curEnd);
            btnSavePayroll.Enabled = false;
            lblMode.Text = "Saved payroll for " + Fmt.Period(curStart, curEnd) + " (Finalized).";
            lblMode.ForeColor = Theme.GreenDark;
            LoadHistory();
            Ui.Info("Payroll saved.");
        }

        // ---------- display ----------
        private void ShowTotals()
        {
            decimal gross = 0m, ded = 0m, net = 0m;
            foreach (PayLine l in lines)
            {
                gross += l.GrossPay;
                ded += l.TotalDeductions;
                net += l.NetPay;
            }
            lblSum1Value.Text = lines.Count.ToString();
            lblSum2Value.Text = Fmt.Money(gross);
            lblSum3Value.Text = Fmt.Money(ded);
            lblSum4Value.Text = Fmt.Money(net);
        }

        private DataTable BuildTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("EmployeeId", typeof(int));
            dt.Columns.Add("EmployeeNo", typeof(string));
            dt.Columns.Add("Employee", typeof(string));
            string[] numeric = { "DaysPaid", "Hours", "OTHours", "Basic", "OTPay", "Allowance", "OtherEarn", "Gross", "Late", "SSS", "PhilHealth", "PagIbig", "Tax", "OtherDed", "TotalDed", "Net" };
            foreach (string n in numeric) dt.Columns.Add(n, typeof(decimal));
            foreach (PayLine l in lines)
            {
                dt.Rows.Add(l.EmployeeId, l.EmployeeNo, l.Name, l.DaysPaid, l.HoursWorked, l.OvertimeHours,
                    l.BasicPay, l.OvertimePay, l.Allowance, l.OtherEarnings, l.GrossPay, l.LateDeduction,
                    l.SSS, l.PhilHealth, l.PagIbig, l.Tax, l.OtherDeductions, l.TotalDeductions, l.NetPay);
            }
            return dt;
        }

        private void BindGrid()
        {
            dgvPayroll.DataSource = BuildTable();
            Ui.HideCol(dgvPayroll, "EmployeeId");
            Ui.Col(dgvPayroll, "EmployeeNo", "ID", null, false, 90);
            Ui.Col(dgvPayroll, "Employee", "Employee", null, false, 190);
            Ui.Col(dgvPayroll, "DaysPaid", "Days", "0.##", true, 65);
            Ui.Col(dgvPayroll, "Hours", "Hours", "N2", true, 75);
            Ui.Col(dgvPayroll, "OTHours", "OT hrs", "N2", true, 70);
            Ui.Col(dgvPayroll, "Basic", "Basic pay", "N2", true, 105);
            Ui.Col(dgvPayroll, "OTPay", "OT pay", "N2", true, 90);
            Ui.Col(dgvPayroll, "Allowance", "Allowance", "N2", true, 95);
            Ui.Col(dgvPayroll, "OtherEarn", "Other earn.", "N2", true, 95);
            Ui.Col(dgvPayroll, "Gross", "Gross pay", "N2", true, 110);
            Ui.Col(dgvPayroll, "Late", "Late / UT", "N2", true, 90);
            Ui.Col(dgvPayroll, "SSS", "SSS", "N2", true, 85);
            Ui.Col(dgvPayroll, "PhilHealth", "PhilHealth", "N2", true, 95);
            Ui.Col(dgvPayroll, "PagIbig", "Pag-IBIG", "N2", true, 90);
            Ui.Col(dgvPayroll, "Tax", "Tax", "N2", true, 90);
            Ui.Col(dgvPayroll, "OtherDed", "Other ded.", "N2", true, 95);
            Ui.Col(dgvPayroll, "TotalDed", "Total ded.", "N2", true, 105);
            Ui.Col(dgvPayroll, "Net", "NET PAY", "N2", true, 120);
            if (dgvPayroll.Columns.Contains("Employee")) dgvPayroll.Columns["Employee"].Frozen = true;
            if (dgvPayroll.Columns.Contains("Net"))
            {
                dgvPayroll.Columns["Net"].DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                dgvPayroll.Columns["Net"].DefaultCellStyle.ForeColor = Theme.TealDark;
            }
            dgvPayroll.ClearSelection();
            ShowTotals();
        }

        // ---------- history ----------
        private void LoadHistory()
        {
            DataTable dt = db.select(
                "SELECT pp.Id, pp.PeriodStart, pp.PeriodEnd, pp.PayDate, pp.Status, (SELECT ISNULL(SUM(NetPay), 0) FROM Payslips WHERE PeriodId = pp.Id) AS Net " +
                "FROM PayrollPeriods pp ORDER BY pp.PeriodEnd DESC");
            var view = new DataTable();
            view.Columns.Add("Id", typeof(int));
            view.Columns.Add("Period", typeof(string));
            view.Columns.Add("Status", typeof(string));
            view.Columns.Add("Net", typeof(decimal));
            foreach (DataRow r in dt.Rows)
                view.Rows.Add(Fmt.I(r["Id"]), Fmt.Period((DateTime)r["PeriodStart"], (DateTime)r["PeriodEnd"]), Fmt.S(r["Status"]), Fmt.D(r["Net"]));
            dgvHistory.DataSource = view;
            Ui.HideCol(dgvHistory, "Id");
            Ui.Col(dgvHistory, "Period", "Period");
            Ui.Col(dgvHistory, "Status", "Status", null, false, 85);
            Ui.Col(dgvHistory, "Net", "Net pay", "N2", true, 100);
            if (!statusHooked)
            {
                Ui.ColorStatus(dgvHistory, "Status");
                statusHooked = true;
            }
            dgvHistory.ClearSelection();
        }

        private int SelectedPeriod()
        {
            if (dgvHistory.SelectedRows.Count == 0)
            {
                Ui.Info("Select a saved payroll in the history list first.");
                return 0;
            }
            return Fmt.I(dgvHistory.SelectedRows[0].Cells["Id"].Value);
        }

        private void btnOpenPeriod_Click(object sender, EventArgs e)
        {
            int id = SelectedPeriod();
            if (id > 0) OpenPeriod(id);
        }

        private void dgvHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) btnOpenPeriod_Click(sender, e);
        }

        private void OpenPeriod(int id)
        {
            DataTable p = db.select("SELECT PeriodStart, PeriodEnd, PayDate, Status FROM PayrollPeriods WHERE Id = @id", new { id = id });
            if (p.Rows.Count == 0) return;
            DataRow r = p.Rows[0];
            curStart = (DateTime)r["PeriodStart"];
            curEnd = (DateTime)r["PeriodEnd"];
            curPay = (DateTime)r["PayDate"];
            dtpStart.Value = curStart;
            dtpEnd.Value = curEnd;
            dtpPayDate.Value = curPay;
            lines = PayrollEngine.LoadSaved(id);
            savedPeriodId = id;
            BindGrid();
            btnSavePayroll.Enabled = false;
            lblMode.Text = "Saved payroll for " + Fmt.Period(curStart, curEnd) + " (" + Fmt.S(r["Status"]) + ").";
            lblMode.ForeColor = Theme.GreenDark;
        }

        private void btnDeletePeriod_Click(object sender, EventArgs e)
        {
            int id = SelectedPeriod();
            if (id == 0) return;
            if (!Ui.Confirm("Delete this saved payroll and all of its payslips?\n\nYou can compute and save it again afterwards.")) return;
            if (!db.DeleteRow("PayrollPeriods", id))
            {
                Ui.Error("The payroll could not be deleted.");
                return;
            }
            if (savedPeriodId == id)
            {
                savedPeriodId = 0;
                lines = new List<PayLine>();
                BindGrid();
                lblMode.Text = "Choose a pay period and press Compute payroll.";
                lblMode.ForeColor = Theme.Muted;
            }
            LoadHistory();
        }

        // ---------- printing ----------
        private bool HasLines()
        {
            if (lines.Count == 0)
            {
                Ui.Info("Compute or open a payroll first.");
                return false;
            }
            return true;
        }

        private void btnPayslip_Click(object sender, EventArgs e)
        {
            if (!HasLines()) return;
            if (dgvPayroll.SelectedRows.Count == 0)
            {
                Ui.Info("Select an employee row first, or use \"All payslips\".");
                return;
            }
            int empId = Fmt.I(dgvPayroll.SelectedRows[0].Cells["EmployeeId"].Value);
            PayLine found = lines.Find(l => l.EmployeeId == empId);
            if (found == null) return;
            PayslipPrinter.Preview(new List<PayLine> { found }, curStart, curEnd, curPay);
        }

        private void btnAllPayslips_Click(object sender, EventArgs e)
        {
            if (!HasLines()) return;
            PayslipPrinter.Preview(lines, curStart, curEnd, curPay);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!HasLines()) return;
            var dt = new DataTable();
            string[] heads = { "ID", "Employee", "Days", "Basic", "OT", "Allow.+Other", "Gross", "Late/UT", "SSS+PH+HDMF", "Tax", "Other Ded.", "Net Pay" };
            foreach (string h in heads) dt.Columns.Add(h, typeof(string));
            decimal tg = 0m, tn = 0m;
            foreach (PayLine l in lines)
            {
                dt.Rows.Add(l.EmployeeNo, l.Name, l.DaysPaid.ToString("0.##", Fmt.Ci), Fmt.Num(l.BasicPay), Fmt.Num(l.OvertimePay),
                    Fmt.Num(l.Allowance + l.OtherEarnings), Fmt.Num(l.GrossPay), Fmt.Num(l.LateDeduction),
                    Fmt.Num(l.SSS + l.PhilHealth + l.PagIbig), Fmt.Num(l.Tax), Fmt.Num(l.OtherDeductions), Fmt.Num(l.NetPay));
                tg += l.GrossPay;
                tn += l.NetPay;
            }
            dt.Rows.Add("", "TOTAL", "", "", "", "", Fmt.Num(tg), "", "", "", "", Fmt.Num(tn));
            red_framework.ReportPrinter.Preview(dt, AppSettings.Company + " - Payroll Register",
                "Pay period: " + Fmt.Period(curStart, curEnd) + "   |   Pay date: " + curPay.ToString("MMM dd, yyyy", Fmt.Ci));
        }

        // ---------- bonuses / deductions tab ----------
        private void tabsPayroll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabsPayroll.SelectedTab == tabAdjust) LoadAdjustments();
        }

        private void AdjFilter_Changed(object sender, EventArgs e)
        {
            if (!loading) LoadAdjustments();
        }

        private void LoadAdjustments()
        {
            if (dtpAdjFrom.Value.Date > dtpAdjTo.Value.Date) return;
            DataTable dt = db.select(
                "SELECT a.Id, a.AdjDate, e.EmployeeNo, e.LastName + N', ' + e.FirstName AS Employee, a.AdjType, a.Description, a.Amount " +
                "FROM Adjustments a INNER JOIN Employees e ON e.Id = a.EmployeeId WHERE a.AdjDate BETWEEN @f AND @t ORDER BY a.AdjDate DESC, e.LastName",
                new { f = dtpAdjFrom.Value.Date, t = dtpAdjTo.Value.Date });
            dgvAdjustments.DataSource = dt;
            Ui.HideCol(dgvAdjustments, "Id");
            Ui.Col(dgvAdjustments, "AdjDate", "Date", "MMM dd, yyyy", false, 115);
            Ui.Col(dgvAdjustments, "EmployeeNo", "ID", null, false, 90);
            Ui.Col(dgvAdjustments, "Employee", "Employee");
            Ui.Col(dgvAdjustments, "AdjType", "Type", null, false, 100);
            Ui.Col(dgvAdjustments, "Description", "Description");
            Ui.Col(dgvAdjustments, "Amount", "Amount", "N2", true, 110);
            dgvAdjustments.ClearSelection();
        }

        private void btnAddAdjustment_Click(object sender, EventArgs e)
        {
            if (Ui.SelectedId(cmbAdjEmployee) <= 0) { Ui.Warn("Please choose an employee."); return; }
            if (!Ui.Required(txtAdjDescription, "Description")) return;
            decimal amount;
            if (!Fmt.TryMoney(txtAdjAmount.Text, out amount) || amount <= 0m)
            {
                Ui.Warn("Please enter an amount greater than zero.");
                txtAdjAmount.Select();
                return;
            }

            bool ok = db.Insert("Adjustments", new
            {
                EmployeeId = Ui.SelectedId(cmbAdjEmployee),
                AdjDate = dtpAdjDate.Value.Date,
                AdjType = cmbAdjType.SelectedIndex <= 0 ? "Earning" : "Deduction",
                Description = txtAdjDescription.Text.Trim(),
                Amount = amount
            });
            if (!ok) { Ui.Error("The entry could not be saved."); return; }

            DateTime d = dtpAdjDate.Value.Date;
            loading = true;
            try
            {
                if (d < dtpAdjFrom.Value.Date) dtpAdjFrom.Value = d;
                if (d > dtpAdjTo.Value.Date) dtpAdjTo.Value = d;
            }
            finally { loading = false; }

            txtAdjDescription.Clear();
            txtAdjAmount.Clear();
            LoadAdjustments();
            Ui.Info("Entry added. Press Compute payroll again to include it.");
        }

        private void btnDeleteAdjustment_Click(object sender, EventArgs e)
        {
            if (dgvAdjustments.SelectedRows.Count == 0)
            {
                Ui.Info("Select an entry in the table first.");
                return;
            }
            if (!Ui.Confirm("Delete the selected entry?")) return;
            int id = Fmt.I(dgvAdjustments.SelectedRows[0].Cells["Id"].Value);
            db.DeleteRow("Adjustments", id);
            LoadAdjustments();
        }
    }
}
