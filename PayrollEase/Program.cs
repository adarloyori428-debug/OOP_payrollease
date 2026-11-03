using System;
using System.Windows.Forms;

namespace PayrollEase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // (ADDED) show a friendly message instead of crashing on an unexpected error
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += delegate (object s, System.Threading.ThreadExceptionEventArgs e)
            {
                MessageBox.Show("Something went wrong:\n\n" + e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            // csharf-classes guide: close the shared AppDb connection once at application exit
            Application.ApplicationExit += delegate { red_framework.AppDb.Dispose(); };

            // (ADDED) login first; after login the main window opens. "Sign out" returns to the login form.
            while (true)
            {
                using (LoginForm login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK) break;
                }

                bool loggedOut;
                using (MainForm main = new MainForm())
                {
                    Application.Run(main);
                    loggedOut = main.LoggedOut;
                }
                Session.Clear();
                if (!loggedOut) break;
            }
        }
    }
}
