using System;
using System.Data;
using System.Windows.Forms;

namespace PayrollEase
{
    public partial class DashboardForm : Form, IRefreshable
    {
        readonly MainForm owner;
        Database db = new Database();
        bool statusHooked;

        public DashboardForm(MainForm owner)
        {
            this.owner = owner;
            InitializeComponent();
        }

        private void Go(string page)
        {
            if (owner != null) owner.ShowPage(page);
        }

        private void btnQuickAttendance_Click(object sender, EventArgs e) { Go("attendance"); }
        private void btnQuickEmployee_Click(object sender, EventArgs e) { Go("employees"); }
        private void btnQuickPayroll_Click(object sender, EventArgs e) { Go("payroll"); }
        private void btnQuickReports_Click(object sender, EventArgs e) { Go("reports"); }

        public void RefreshData()
        {
            DateTime today = DateTime.Today;

            string first = Session.FullName;
            int sp = first.IndexOf(' ');
            if (sp > 0) first = first.Substring(0, sp);
            string part = DateTime.Now.Hour < 12 ? "Good morning" : (DateTime.Now.Hour < 18 ? "Good afternoon" : "Good evening");
            lblGreeting.Text = part + ", " + first;
            lblDate.Text = AppSettings.Company + "   |   " + today.ToString("dddd, MMMM dd", Fmt.Ci);

            int employees = Fmt.I(db.Scalar("SELECT COUNT(*) FROM Employees WHERE IsActive = 1"));
            int present = Fmt.I(db.Scalar("SELECT COUNT(*) FROM Attendance WHERE WorkDate = @d AND Status IN (N'Present', N'Late', N'Half Day')", new { d = today }));
            int late = Fmt.I(db.Scalar("SELECT COUNT(*) FROM Attendance WHERE WorkDate = @d AND Status = N'Late'", new { d = today }));
            int away = Fmt.I(db.Scalar(
                "SELECT COUNT(*) FROM Employees e WHERE e.IsActive = 1 AND NOT EXISTS (SELECT 1 FROM Attendance a WHERE a.EmployeeId = e.Id AND a.WorkDate = @d AND a.Status IN (N'Present', N'Late', N'Half Day'))",
                new { d = today }));
            int onLeave = Fmt.I(db.Scalar("SELECT COUNT(*) FROM Attendance WHERE WorkDate = @d AND Status = N'Leave'", new { d = today }));

            lblStat1Value.Text = employees.ToString();
            lblStat1Caption.Text = "registered and active";
            lblStat2Value.Text = present.ToString();
            lblStat2Caption.Text = employees > 0 ? (present * 100 / employees) + "% of the team" : "no employees yet";
            lblStat3Value.Text = late.ToString();
            lblStat3Caption.Text = late == 0 ? "everyone is on time" : "arrived after grace period";
            lblStat4Value.Text = away.ToString();
            lblStat4Caption.Text = onLeave > 0 ? onLeave + " on approved leave" : "no punch recorded yet";

            DataTable last = db.select(
                "SELECT TOP 1 pp.PeriodStart, pp.PeriodEnd, (SELECT ISNULL(SUM(NetPay), 0) FROM Payslips WHERE PeriodId = pp.Id) AS Net " +
                "FROM PayrollPeriods pp ORDER BY pp.PeriodEnd DESC");
            if (last.Rows.Count > 0)
            {
                DataRow r = last.Rows[0];
                lblStat5Value.Text = Fmt.Money(Fmt.D(r["Net"]));
                lblStat5Caption.Text = Fmt.Period((DateTime)r["PeriodStart"], (DateTime)r["PeriodEnd"]);
            }
            else
            {
                lblStat5Value.Text = Fmt.Money(0m);
                lblStat5Caption.Text = "no payroll saved yet";
            }

            LoadAttendanceChart(today);
            LoadPayrollChart();
            LoadRecent();
        }

        private void LoadAttendanceChart(DateTime today)
        {
            DateTime rangeStart = today.AddDays(-6);
            DataTable counts = db.select(
                "SELECT WorkDate, COUNT(*) AS Cnt FROM Attendance WHERE WorkDate BETWEEN @s AND @e AND Status IN (N'Present', N'Late', N'Half Day') GROUP BY WorkDate",
                new { s = rangeStart, e = today });
            var dt = new DataTable();
            dt.Columns.Add("Day", typeof(string));
            dt.Columns.Add("Present", typeof(int));
            for (int i = 0; i < 7; i++)
            {
                DateTime d = rangeStart.AddDays(i);
                int n = 0;
                foreach (DataRow r in counts.Rows)
                    if (((DateTime)r["WorkDate"]).Date == d.Date) n = Fmt.I(r["Cnt"]);
                dt.Rows.Add(d.ToString("ddd dd", Fmt.Ci), n);
            }
            ChartHelper.Column(chartAttendance, dt, "Day", "Present", "Present", Theme.Teal);
        }

        private void LoadPayrollChart()
        {
            DataTable src = db.select(
                "SELECT x.PeriodEnd, x.Net FROM (SELECT TOP 6 pp.PeriodEnd, ISNULL(SUM(ps.NetPay), 0) AS Net " +
                "FROM PayrollPeriods pp LEFT JOIN Payslips ps ON ps.PeriodId = pp.Id GROUP BY pp.Id, pp.PeriodEnd ORDER BY pp.PeriodEnd DESC) x ORDER BY x.PeriodEnd");
            var dt = new DataTable();
            dt.Columns.Add("Period", typeof(string));
            dt.Columns.Add("Net", typeof(decimal));
            foreach (DataRow r in src.Rows)
                dt.Rows.Add(((DateTime)r["PeriodEnd"]).ToString("MMM dd", Fmt.Ci), Fmt.D(r["Net"]));
            ChartHelper.Line(chartPayroll, dt, "Period", "Net", "Net pay", Theme.Violet);
        }

        private void LoadRecent()
        {
            DataTable dt = db.select(
                "SELECT TOP 8 e.LastName + N', ' + e.FirstName AS Employee, a.WorkDate, a.TimeIn, a.TimeOut, a.Status " +
                "FROM Attendance a INNER JOIN Employees e ON e.Id = a.EmployeeId WHERE a.TimeIn IS NOT NULL " +
                "ORDER BY ISNULL(a.TimeOut, a.TimeIn) DESC");
            dgvRecent.DataSource = dt;
            Ui.Col(dgvRecent, "Employee", "Employee");
            Ui.Col(dgvRecent, "WorkDate", "Date", "MMM dd, yyyy", false, 0);
            Ui.Col(dgvRecent, "TimeIn", "Time in", "hh:mm tt", false, 0);
            Ui.Col(dgvRecent, "TimeOut", "Time out", "hh:mm tt", false, 0);
            Ui.Col(dgvRecent, "Status", "Status");
            if (!statusHooked)
            {
                Ui.ColorStatus(dgvRecent, "Status");
                statusHooked = true;
            }
            dgvRecent.ClearSelection();
        }
    }
}
