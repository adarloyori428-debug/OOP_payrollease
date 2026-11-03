using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollEase
{
  
    public interface IRefreshable
    {
        void RefreshData();
    }

    public partial class MainForm : Form
    {
        public bool LoggedOut { get; private set; }

        readonly Dictionary<string, Form> pages = new Dictionary<string, Form>();
        readonly Dictionary<string, Button> navButtons = new Dictionary<string, Button>();
        readonly Dictionary<string, string[]> titles = new Dictionary<string, string[]>
        {
            { "dashboard", new[] { "Dashboard", "Overview of today's attendance and payroll" } },
            { "employees", new[] { "Employees", "Manage employee records, pay rates and government numbers" } },
            { "attendance", new[] { "Attendance", "Time in / time out, late, undertime and overtime tracking" } },
            { "payroll", new[] { "Payroll", "Compute, save and print payroll for any pay period" } },
            { "reports", new[] { "Reports", "Preview, print or export payroll and attendance reports" } },
            { "settings", new[] { "Settings", "Company details, work schedule, payroll rules and users" } }
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = "PayrollEase - " + AppSettings.Company;
            navButtons["dashboard"] = btnDashboard;
            navButtons["employees"] = btnEmployees;
            navButtons["attendance"] = btnAttendance;
            navButtons["payroll"] = btnPayroll;
            navButtons["reports"] = btnReports;
            navButtons["settings"] = btnSettings;

            lblUserName.Text = Session.FullName;
            lblUserRole.Text = Session.IsAdmin ? "Administrator" : "HR Staff";
            lblAvatar.Text = Fmt.Initials(Session.FullName);
            WindowState = FormWindowState.Maximized;
            UpdateClock();
            ShowPage("dashboard");
        }

        private void UpdateClock()
        {
            lblClock.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy   |   hh:mm:ss tt", Fmt.Ci);
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private Form CreatePage(string key)
        {
            switch (key)
            {
                case "dashboard": return new DashboardForm(this);
                case "employees": return new EmployeesForm();
                case "attendance": return new AttendanceForm();
                case "payroll": return new PayrollForm();
                case "reports": return new ReportsForm();
                case "settings": return new SettingsForm();
                default: return null;
            }
        }

        public void ShowPage(string key)
        {
            Form page;
            if (!pages.TryGetValue(key, out page))
            {
                page = CreatePage(key);
                if (page == null) return;
                page.TopLevel = false;
                page.FormBorderStyle = FormBorderStyle.None;
                page.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(page);
                pages[key] = page;
            }

            foreach (KeyValuePair<string, Form> kv in pages)
                if (kv.Value != page) kv.Value.Hide();
            page.Show();
            page.BringToFront();

            lblPageTitle.Text = titles[key][0];
            lblPageSubtitle.Text = titles[key][1];

            foreach (KeyValuePair<string, Button> kv in navButtons)
            {
                bool active = kv.Key == key;
                kv.Value.BackColor = active ? Theme.NavyLight : Theme.Navy;
                kv.Value.ForeColor = active ? Color.White : Theme.NavText;
            }

            IRefreshable r = page as IRefreshable;
            if (r != null)
            {
                try { r.RefreshData(); }
                catch (Exception ex) { Ui.Error("This page could not be loaded.\n\n" + ex.Message); }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e) { ShowPage("dashboard"); }
        private void btnEmployees_Click(object sender, EventArgs e) { ShowPage("employees"); }
        private void btnAttendance_Click(object sender, EventArgs e) { ShowPage("attendance"); }
        private void btnPayroll_Click(object sender, EventArgs e) { ShowPage("payroll"); }
        private void btnReports_Click(object sender, EventArgs e) { ShowPage("reports"); }
        private void btnSettings_Click(object sender, EventArgs e) { ShowPage("settings"); }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (Ui.Confirm("Sign out of PayrollEase?"))
            {
                LoggedOut = true;
                Close();
            }
        }
    }
}
