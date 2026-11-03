using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace PayrollEase
{
    public partial class SettingsForm : Form, IRefreshable
    {
        Database db = new Database();
        // the User ID text box holds the selected user (empty = nothing selected), like StudentManagementSystem
        int selectedUserId
        {
            get { int v; return int.TryParse(txtUserID.Text, out v) ? v : 0; }
        }
        bool loading;
        bool statusHooked;

        static readonly string[] NumericKeys =
        {
            "BreakHours", "GraceMinutes", "HalfDayHours", "MinOvertimeMinutes", "OvertimeMultiplier", "HoursPerDay",
            "SSSMinMSC", "SSSMaxMSC", "PhilHealthFloor", "PhilHealthCeiling", "PagIbigMaxBase",
            "SSSRate", "PhilHealthRate", "PagIbigRate"
        };
        static readonly string[] PercentKeys = { "SSSRate", "PhilHealthRate", "PagIbigRate" };

        // setting key -> the control that edits it
        readonly Dictionary<string, Control> inputs = new Dictionary<string, Control>();

        public SettingsForm()
        {
            InitializeComponent();

            inputs["CompanyName"] = txtCompanyName;
            inputs["CompanyAddress"] = txtCompanyAddress;
            inputs["CompanyContact"] = txtCompanyContact;
            inputs["WorkStart"] = dtpWorkStart;
            inputs["WorkEnd"] = dtpWorkEnd;
            inputs["BreakHours"] = txtBreakHours;
            inputs["GraceMinutes"] = txtGraceMinutes;
            inputs["HalfDayHours"] = txtHalfDayHours;
            inputs["MinOvertimeMinutes"] = txtMinOvertimeMinutes;
            inputs["WorkDaysPerWeek"] = cmbWorkDaysPerWeek;
            inputs["HoursPerDay"] = txtHoursPerDay;
            inputs["PayPeriodsPerMonth"] = cmbPayPeriodsPerMonth;
            inputs["OvertimeMultiplier"] = txtOvertimeMultiplier;
            inputs["DeductLate"] = chkDeductLate;
            inputs["ApplySSS"] = chkApplySSS;
            inputs["ApplyPhilHealth"] = chkApplyPhilHealth;
            inputs["ApplyPagIbig"] = chkApplyPagIbig;
            inputs["ApplyTax"] = chkApplyTax;
            inputs["SSSRate"] = txtSSSRate;
            inputs["SSSMinMSC"] = txtSSSMinMSC;
            inputs["SSSMaxMSC"] = txtSSSMaxMSC;
            inputs["PhilHealthRate"] = txtPhilHealthRate;
            inputs["PhilHealthFloor"] = txtPhilHealthFloor;
            inputs["PhilHealthCeiling"] = txtPhilHealthCeiling;
            inputs["PagIbigRate"] = txtPagIbigRate;
            inputs["PagIbigMaxBase"] = txtPagIbigMaxBase;

            cmbUserRole.SelectedIndex = 1;

            if (!Session.IsAdmin)
            {
                // HR staff can only change their own password
                tabsSettings.TabPages.Remove(tabCompany);
                tabsSettings.TabPages.Remove(tabSchedule);
                tabsSettings.TabPages.Remove(tabRules);
                tabsSettings.TabPages.Remove(tabUsers);
                tabsSettings.TabPages.Remove(tabData);
                pnlSaveBar.Visible = false;
            }
        }

        public void RefreshData()
        {
            lblAccountInfo.Text = Session.FullName + "   |   " + (Session.IsAdmin ? "Administrator" : "HR Staff") + "   |   @" + Session.Username;
            if (!Session.IsAdmin) return;

            AppSettings.Reload();
            LoadValues();
            LoadUsers();
            lblDatabase.Text = "Database file:  " + Database.DbPath;
        }

        static string FormatNumber(decimal v)
        {
            return v.ToString("0.####", CultureInfo.InvariantCulture);
        }

        private void LoadValues()
        {
            foreach (KeyValuePair<string, Control> kv in inputs)
            {
                string key = kv.Key;
                Control c = kv.Value;
                string raw = AppSettings.Get(key);

                if (c is CheckBox) ((CheckBox)c).Checked = raw == "1";
                else if (c is DateTimePicker) ((DateTimePicker)c).Value = DateTime.Today.Add(AppSettings.GetTime(key));
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    int idx = cb.FindStringExact(raw);
                    cb.SelectedIndex = idx >= 0 ? idx : 0;
                }
                else if (Array.IndexOf(PercentKeys, key) >= 0) c.Text = FormatNumber(AppSettings.GetDecimal(key) * 100m);
                else if (Array.IndexOf(NumericKeys, key) >= 0) c.Text = FormatNumber(AppSettings.GetDecimal(key));
                else c.Text = raw;
            }
        }

        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            if (!Ui.Confirm("Reset all settings on these tabs to the default values?\n\nNothing is saved until you press Save settings.")) return;
            foreach (KeyValuePair<string, Control> kv in inputs)
            {
                string def;
                if (!AppSettings.Defaults.TryGetValue(kv.Key, out def)) continue;
                Control c = kv.Value;
                decimal d;
                if (c is CheckBox) ((CheckBox)c).Checked = def == "1";
                else if (c is DateTimePicker)
                {
                    DateTime t;
                    if (DateTime.TryParseExact(def, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out t))
                        ((DateTimePicker)c).Value = DateTime.Today.Add(t.TimeOfDay);
                }
                else if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    int idx = cb.FindStringExact(def);
                    cb.SelectedIndex = idx >= 0 ? idx : 0;
                }
                else if (Array.IndexOf(PercentKeys, kv.Key) >= 0 && decimal.TryParse(def, NumberStyles.Number, CultureInfo.InvariantCulture, out d))
                    c.Text = FormatNumber(d * 100m);
                else c.Text = def;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>();
            foreach (KeyValuePair<string, Control> kv in inputs)
            {
                string key = kv.Key;
                Control c = kv.Value;

                if (c is CheckBox) values[key] = ((CheckBox)c).Checked ? "1" : "0";
                else if (c is DateTimePicker) values[key] = ((DateTimePicker)c).Value.ToString("HH:mm", CultureInfo.InvariantCulture);
                else if (c is ComboBox)
                {
                    if (string.IsNullOrEmpty(c.Text)) { Ui.Warn("Please choose a value for every dropdown."); return; }
                    values[key] = c.Text;
                }
                else if (Array.IndexOf(NumericKeys, key) >= 0)
                {
                    decimal d;
                    if (!Fmt.TryMoney(c.Text.Trim(), out d) || d < 0m)
                    {
                        Ui.Warn("Please enter a valid number (0 or higher) for every numeric setting.");
                        c.Select();
                        return;
                    }
                    if (Array.IndexOf(PercentKeys, key) >= 0)
                    {
                        if (d > 100m) { Ui.Warn("A percentage cannot be more than 100."); c.Select(); return; }
                        d = d / 100m;
                    }
                    values[key] = d.ToString(CultureInfo.InvariantCulture);
                }
                else values[key] = c.Text.Trim();
            }

            if (values["CompanyName"].Length == 0) { Ui.Warn("The company name is required."); return; }

            DateTime tmp;
            DateTime.TryParseExact(values["WorkStart"], "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp);
            TimeSpan ws = tmp.TimeOfDay;
            DateTime.TryParseExact(values["WorkEnd"], "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp);
            TimeSpan we = tmp.TimeOfDay;
            if (we <= ws) { Ui.Warn("The shift end must be later than the shift start."); return; }
            if (Fmt.D(values["SSSMinMSC"]) > Fmt.D(values["SSSMaxMSC"]) || Fmt.D(values["PhilHealthFloor"]) > Fmt.D(values["PhilHealthCeiling"]))
            {
                Ui.Warn("A minimum / floor value cannot be higher than its maximum / ceiling.");
                return;
            }
            decimal hpd = Fmt.D(values["HoursPerDay"]);
            if (hpd < 1m || hpd > 24m) { Ui.Warn("Paid hours per day must be between 1 and 24."); return; }

            try
            {
                foreach (KeyValuePair<string, string> kv in values) AppSettings.Set(kv.Key, kv.Value);
            }
            catch (Exception ex)
            {
                Ui.Error("The settings could not be saved.\n\n" + ex.Message);
                return;
            }
            Ui.Info("Settings saved.");
        }

        // ---------- my account ----------
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (!Ui.Required(txtCurrentPassword, "Current password")) return;
            if (!Ui.Required(txtNewPassword, "New password")) return;
            if (!Ui.Required(txtConfirmPassword, "Confirmation")) return;
            if (txtNewPassword.Text.Length < 6) { Ui.Warn("The new password must be at least 6 characters."); return; }
            if (txtNewPassword.Text != txtConfirmPassword.Text) { Ui.Warn("The new password and its confirmation do not match."); return; }

            string stored = Fmt.S(db.Scalar("SELECT PasswordHash FROM Users WHERE Id = @id", new { id = Session.UserId }));
            if (!PasswordHasher.Verify(txtCurrentPassword.Text, stored))
            {
                Ui.Warn("The current password is incorrect.");
                txtCurrentPassword.Select();
                return;
            }
            db.UpdateRow("Users", new { PasswordHash = PasswordHasher.Hash(txtNewPassword.Text) }, Session.UserId);
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            Ui.Info("Password changed.");
        }

        // ---------- users ----------
        private void LoadUsers()
        {
            DataTable dt = db.select(
                "SELECT Id, Username, FullName, [Role], CASE WHEN IsActive = 1 THEN N'Active' ELSE N'Inactive' END AS State, LastLogin FROM Users ORDER BY Username");
            loading = true;
            try
            {
                dgvUsers.DataSource = dt;
                Ui.HideCol(dgvUsers, "Id");
                Ui.Col(dgvUsers, "Username", "Username");
                Ui.Col(dgvUsers, "FullName", "Full name");
                Ui.Col(dgvUsers, "Role", "Role", null, false, 90);
                Ui.Col(dgvUsers, "State", "State", null, false, 100);
                Ui.Col(dgvUsers, "LastLogin", "Last sign-in", "MMM dd, yyyy hh:mm tt", false, 190);
                if (!statusHooked)
                {
                    Ui.ColorStatus(dgvUsers, "State");
                    statusHooked = true;
                }
                dgvUsers.ClearSelection();
            }
            finally { loading = false; }
        }

        private int ActiveAdminCount()
        {
            return Fmt.I(db.Scalar("SELECT COUNT(*) FROM Users WHERE [Role] = N'Admin' AND IsActive = 1"));
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtUserName.Clear();
            txtUserFullName.Clear();
            txtUserPassword.Clear();
            cmbUserRole.SelectedIndex = 1;
            txtUserName.ReadOnly = false;
            dgvUsers.ClearSelection();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Fmt.I(dgvUsers.Rows[e.RowIndex].Cells["Id"].Value);
            DataRow r = db.GetRow("Users", id);
            if (r == null) return;
            txtUserID.Text = id.ToString();
            txtUserName.Text = Fmt.S(r["Username"]);
            txtUserFullName.Text = Fmt.S(r["FullName"]);
            int idx = cmbUserRole.FindStringExact(Fmt.S(r["Role"]));
            cmbUserRole.SelectedIndex = idx >= 0 ? idx : 1;
            txtUserPassword.Clear();
            txtUserName.ReadOnly = true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!Ui.Required(txtUserName, "Username")) return;
            if (!Ui.Required(txtUserFullName, "Full name")) return;
            if (!Ui.Required(txtUserPassword, "Password")) return;
            string username = txtUserName.Text.Trim();
            if (username.Contains(" ")) { Ui.Warn("The username cannot contain spaces."); return; }
            if (txtUserPassword.Text.Length < 6) { Ui.Warn("The password must be at least 6 characters."); return; }
            if (Fmt.I(db.Scalar("SELECT COUNT(*) FROM Users WHERE Username = @u", new { u = username })) > 0)
            {
                Ui.Warn("That username is already taken.");
                return;
            }
            bool ok = db.Insert("Users", new
            {
                Username = username,
                FullName = txtUserFullName.Text.Trim(),
                Role = cmbUserRole.Text,
                PasswordHash = PasswordHasher.Hash(txtUserPassword.Text),
                IsActive = true
            });
            if (!ok) { Ui.Error("The user could not be created."); return; }
            btnClearUser_Click(sender, e);
            LoadUsers();
            Ui.Info("User created.");
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0) { Ui.Info("Select a user in the list first."); return; }
            if (!Ui.Required(txtUserFullName, "Full name")) return;
            if (selectedUserId == Session.UserId && cmbUserRole.Text != "Admin")
            {
                Ui.Warn("You cannot remove your own administrator role.");
                return;
            }
            if (cmbUserRole.Text != "Admin")
            {
                string current = Fmt.S(db.Scalar("SELECT [Role] FROM Users WHERE Id = @id", new { id = selectedUserId }));
                if (current == "Admin" && ActiveAdminCount() <= 1)
                {
                    Ui.Warn("At least one active administrator is required.");
                    return;
                }
            }
            db.UpdateRow("Users", new { FullName = txtUserFullName.Text.Trim(), Role = cmbUserRole.Text }, selectedUserId);
            LoadUsers();
            Ui.Info("User updated.");
        }

        private void btnResetUserPassword_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0) { Ui.Info("Select a user in the list first."); return; }
            if (txtUserPassword.Text.Length < 6)
            {
                Ui.Warn("Type the new password (at least 6 characters) in the Password box, then press Reset password.");
                txtUserPassword.Select();
                return;
            }
            db.UpdateRow("Users", new { PasswordHash = PasswordHasher.Hash(txtUserPassword.Text) }, selectedUserId);
            txtUserPassword.Clear();
            Ui.Info("Password reset.");
        }

        private void btnToggleUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0) { Ui.Info("Select a user in the list first."); return; }
            DataRow r = db.GetRow("Users", selectedUserId);
            if (r == null) return;
            bool active = Fmt.B(r["IsActive"]);
            if (active)
            {
                if (selectedUserId == Session.UserId) { Ui.Warn("You cannot deactivate your own account."); return; }
                if (Fmt.S(r["Role"]) == "Admin" && ActiveAdminCount() <= 1)
                {
                    Ui.Warn("At least one active administrator is required.");
                    return;
                }
            }
            db.UpdateRow("Users", new { IsActive = !active }, selectedUserId);
            LoadUsers();
        }

        // ---------- sample data ----------
        private void btnLoadDemo_Click(object sender, EventArgs e)
        {
            if (DemoData.IsLoaded()) { Ui.Info("The sample data is already loaded."); return; }
            if (!Ui.Confirm("Add 8 sample employees with about 3 weeks of attendance?\n\nYou can remove them later with \"Remove sample data\".")) return;
            Cursor = Cursors.WaitCursor;
            try
            {
                DemoData.Load();
            }
            catch (Exception ex)
            {
                Ui.Error("The sample data could not be loaded.\n\n" + ex.Message);
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            Ui.Info("Sample data loaded.");
        }

        private void btnRemoveDemo_Click(object sender, EventArgs e)
        {
            if (!DemoData.IsLoaded()) { Ui.Info("There is no sample data to remove."); return; }
            if (!Ui.Confirm("Remove the sample employees and all of their attendance and payroll records?")) return;
            if (DemoData.Remove()) Ui.Info("Sample data removed.");
            else Ui.Error("The sample data could not be removed.");
        }
    }
}
