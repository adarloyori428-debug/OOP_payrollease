using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PayrollEase
{
    public partial class LoginForm : Form
    {
        Database db = new Database();
        int fails;
        DateTime lockUntil = DateTime.MinValue;

        static string RememberPath
        {
            get
            {
                string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PayrollEase");
                return Path.Combine(dir, "login.txt");
            }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                // creates PayrollEaseDB.mdf and the tables if they are missing (same idea as StudentManagementSystem)
                db.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message +
                    "\n\nMake sure SQL Server LocalDB is installed (it comes with Visual Studio).",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (File.Exists(RememberPath))
                {
                    string u = File.ReadAllText(RememberPath).Trim();
                    if (u.Length > 0)
                    {
                        txtUsername.Text = u;
                        chkRemember.Checked = true;
                    }
                }
            }
            catch { }

            try
            {
                int fresh = Fmt.I(db.Scalar("SELECT COUNT(*) FROM Users WHERE Username = N'admin' AND LastLogin IS NULL"));
                if (fresh > 0) lblHint.Text = "First time here? Sign in with admin / admin123 and change the password in Settings.";
            }
            catch { }

            if (txtUsername.Text.Length > 0) txtPassword.Select(); else txtUsername.Select();
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ui.Info("Please ask your PayrollEase administrator to reset your password.\n\nAdministrators can do this under Settings > Users.");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (DateTime.Now < lockUntil)
            {
                int secs = (int)Math.Ceiling((lockUntil - DateTime.Now).TotalSeconds);
                lblError.Text = "Too many failed attempts. Try again in " + secs + " seconds.";
                return;
            }

            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;
            if (user.Length == 0 || pass.Length == 0)
            {
                lblError.Text = "Please enter your username and password.";
                return;
            }

            try
            {
                DataTable dt = db.select(
                    "SELECT Id, Username, FullName, [Role], PasswordHash, IsActive FROM Users WHERE Username = @u",
                    new { u = user });
                DataRow row = dt.Rows.Count > 0 ? dt.Rows[0] : null;

                bool ok = row != null && Fmt.B(row["IsActive"]) && PasswordHasher.Verify(pass, Fmt.S(row["PasswordHash"]));
                if (!ok)
                {
                    fails++;
                    if (row != null && !Fmt.B(row["IsActive"]))
                        lblError.Text = "This account is deactivated. Contact your administrator.";
                    else
                        lblError.Text = "Incorrect username or password.";
                    if (fails >= 5)
                    {
                        lockUntil = DateTime.Now.AddSeconds(30);
                        fails = 0;
                        lblError.Text = "Too many failed attempts. Please wait 30 seconds.";
                    }
                    txtPassword.Clear();
                    txtPassword.Select();
                    return;
                }

                Session.UserId = Fmt.I(row["Id"]);
                Session.Username = Fmt.S(row["Username"]);
                Session.FullName = Fmt.S(row["FullName"]);
                Session.Role = Fmt.S(row["Role"]);
                db.CUD("UPDATE Users SET LastLogin = SYSDATETIME() WHERE Id = @id", new { id = Session.UserId });

                try
                {
                    string dir = Path.GetDirectoryName(RememberPath);
                    if (chkRemember.Checked)
                    {
                        Directory.CreateDirectory(dir);
                        File.WriteAllText(RememberPath, Session.Username);
                    }
                    else if (File.Exists(RememberPath))
                    {
                        File.Delete(RememberPath);
                    }
                }
                catch { }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "Sign in failed: " + ex.Message;
            }
        }
    }
}
