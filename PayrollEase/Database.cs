using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PayrollEase
{
    // (ADDED) One SQL statement + parameters, used by Database.Transaction() so payroll can save all payslips or none.
    public class SqlBatchItem
    {
        public string Sql;
        public object Parameters;

        public SqlBatchItem(string sql, object parameters)
        {
            Sql = sql;
            Parameters = parameters;
        }
    }

    // Follows StudentManagementSystem/Database.cs  (Initialize() creates the service-based .mdf automatically)
    // and WindowsFormsAppDB/Database.cs           (CUD, create, update, delete, select).
    public class Database
    {
        // Service-Based Database (.mdf) stored next to the .exe (bin\Debug)   <- same as StudentManagementSystem
        static readonly string DbFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PayrollEaseDB.mdf");
        static readonly string LogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PayrollEaseDB_log.ldf");

        const string ServerConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30";

        // Uses the same "AppDB" connection string from App.config as the csharf-classes AppDb class, so both open the same .mdf.
        // (If App.config has no AppDB string, it falls back to the file next to the .exe, like StudentManagementSystem.)
        string constring = GetConnectionString();

        static string GetConnectionString()
        {
            ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings["AppDB"];
            if (cs != null && !string.IsNullOrWhiteSpace(cs.ConnectionString)) return cs.ConnectionString;
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DbFile + ";Integrated Security=True;Connect Timeout=30";
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        // ------------------------------------------------------------------------------------------
        // Tables. (ADDED) StudentManagementSystem has one table; PayrollEase needs these.
        // ------------------------------------------------------------------------------------------
        static readonly string[] Schema =
        {
@"IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
CREATE TABLE dbo.Users (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    FullName NVARCHAR(100) NOT NULL,
    [Role] NVARCHAR(20) NOT NULL,
    PasswordHash NVARCHAR(250) NOT NULL,
    IsActive BIT NOT NULL CONSTRAINT DF_Users_IsActive DEFAULT 1,
    CreatedAt DATETIME2 NOT NULL CONSTRAINT DF_Users_CreatedAt DEFAULT SYSDATETIME(),
    LastLogin DATETIME2 NULL
)",
@"IF OBJECT_ID(N'dbo.Settings', N'U') IS NULL
CREATE TABLE dbo.Settings (
    SettingKey NVARCHAR(50) NOT NULL PRIMARY KEY,
    SettingValue NVARCHAR(200) NOT NULL
)",
@"IF OBJECT_ID(N'dbo.Employees', N'U') IS NULL
CREATE TABLE dbo.Employees (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    EmployeeNo NVARCHAR(30) NOT NULL UNIQUE,
    FirstName NVARCHAR(60) NOT NULL,
    MiddleName NVARCHAR(60) NOT NULL CONSTRAINT DF_Emp_Middle DEFAULT N'',
    LastName NVARCHAR(60) NOT NULL,
    Position NVARCHAR(80) NOT NULL CONSTRAINT DF_Emp_Position DEFAULT N'',
    Department NVARCHAR(80) NOT NULL CONSTRAINT DF_Emp_Dept DEFAULT N'',
    ContactNumber NVARCHAR(30) NOT NULL CONSTRAINT DF_Emp_Contact DEFAULT N'',
    Email NVARCHAR(100) NOT NULL CONSTRAINT DF_Emp_Email DEFAULT N'',
    Address NVARCHAR(200) NOT NULL CONSTRAINT DF_Emp_Address DEFAULT N'',
    DateHired DATE NOT NULL,
    PayType NVARCHAR(10) NOT NULL,
    Rate DECIMAL(18,2) NOT NULL,
    Allowance DECIMAL(18,2) NOT NULL CONSTRAINT DF_Emp_Allow DEFAULT 0,
    SSSNo NVARCHAR(30) NOT NULL CONSTRAINT DF_Emp_SSS DEFAULT N'',
    PhilHealthNo NVARCHAR(30) NOT NULL CONSTRAINT DF_Emp_PH DEFAULT N'',
    PagIbigNo NVARCHAR(30) NOT NULL CONSTRAINT DF_Emp_HDMF DEFAULT N'',
    TIN NVARCHAR(30) NOT NULL CONSTRAINT DF_Emp_TIN DEFAULT N'',
    IsActive BIT NOT NULL CONSTRAINT DF_Emp_Active DEFAULT 1
)",
@"IF OBJECT_ID(N'dbo.Attendance', N'U') IS NULL
CREATE TABLE dbo.Attendance (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    EmployeeId INT NOT NULL CONSTRAINT FK_Att_Emp FOREIGN KEY REFERENCES dbo.Employees(Id),
    WorkDate DATE NOT NULL,
    TimeIn DATETIME2 NULL,
    TimeOut DATETIME2 NULL,
    HoursWorked DECIMAL(9,2) NOT NULL CONSTRAINT DF_Att_Hours DEFAULT 0,
    LateMinutes INT NOT NULL CONSTRAINT DF_Att_Late DEFAULT 0,
    UndertimeMinutes INT NOT NULL CONSTRAINT DF_Att_Under DEFAULT 0,
    OvertimeHours DECIMAL(9,2) NOT NULL CONSTRAINT DF_Att_OT DEFAULT 0,
    Status NVARCHAR(15) NOT NULL,
    Remarks NVARCHAR(200) NOT NULL CONSTRAINT DF_Att_Remarks DEFAULT N'',
    CONSTRAINT UQ_Attendance UNIQUE (EmployeeId, WorkDate)
)",
@"IF OBJECT_ID(N'dbo.Adjustments', N'U') IS NULL
CREATE TABLE dbo.Adjustments (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    EmployeeId INT NOT NULL CONSTRAINT FK_Adj_Emp FOREIGN KEY REFERENCES dbo.Employees(Id),
    AdjDate DATE NOT NULL,
    AdjType NVARCHAR(12) NOT NULL,
    Description NVARCHAR(120) NOT NULL,
    Amount DECIMAL(18,2) NOT NULL
)",
@"IF OBJECT_ID(N'dbo.PayrollPeriods', N'U') IS NULL
CREATE TABLE dbo.PayrollPeriods (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    PeriodStart DATE NOT NULL,
    PeriodEnd DATE NOT NULL,
    PayDate DATE NOT NULL,
    Status NVARCHAR(12) NOT NULL,
    CreatedAt DATETIME2 NOT NULL CONSTRAINT DF_Per_Created DEFAULT SYSDATETIME(),
    CreatedBy NVARCHAR(50) NOT NULL CONSTRAINT DF_Per_By DEFAULT N'',
    CONSTRAINT UQ_Period UNIQUE (PeriodStart, PeriodEnd)
)",
@"IF OBJECT_ID(N'dbo.Payslips', N'U') IS NULL
CREATE TABLE dbo.Payslips (
    Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    PeriodId INT NOT NULL CONSTRAINT FK_Slip_Period FOREIGN KEY REFERENCES dbo.PayrollPeriods(Id) ON DELETE CASCADE,
    EmployeeId INT NOT NULL CONSTRAINT FK_Slip_Emp FOREIGN KEY REFERENCES dbo.Employees(Id),
    DaysPaid DECIMAL(9,2) NOT NULL,
    HoursWorked DECIMAL(9,2) NOT NULL,
    OvertimeHours DECIMAL(9,2) NOT NULL,
    LateMinutes INT NOT NULL,
    UndertimeMinutes INT NOT NULL,
    DailyRate DECIMAL(18,2) NOT NULL,
    HourlyRate DECIMAL(18,4) NOT NULL,
    BasicPay DECIMAL(18,2) NOT NULL,
    OvertimePay DECIMAL(18,2) NOT NULL,
    Allowance DECIMAL(18,2) NOT NULL,
    OtherEarnings DECIMAL(18,2) NOT NULL,
    GrossPay DECIMAL(18,2) NOT NULL,
    LateDeduction DECIMAL(18,2) NOT NULL,
    SSS DECIMAL(18,2) NOT NULL,
    PhilHealth DECIMAL(18,2) NOT NULL,
    PagIbig DECIMAL(18,2) NOT NULL,
    Tax DECIMAL(18,2) NOT NULL,
    OtherDeductions DECIMAL(18,2) NOT NULL,
    TotalDeductions DECIMAL(18,2) NOT NULL,
    NetPay DECIMAL(18,2) NOT NULL,
    CONSTRAINT UQ_Payslip UNIQUE (PeriodId, EmployeeId)
)"
        };

        // Creates PayrollEaseDB.mdf (if missing) and the tables (if missing).
        // Runs automatically when the login form loads, so no manual database setup is needed.   <- same idea as StudentManagementSystem
        public void Initialize()
        {
            if (!File.Exists(DbFile))
            {
                if (File.Exists(LogFile))
                {
                    File.Delete(LogFile);
                }

                using (SqlConnection c = new SqlConnection(ServerConnection))
                {
                    c.Open();

                    // Remove a stale registration of PayrollEaseDB (e.g. if the old .mdf was deleted)
                    Run(c, "IF DB_ID(N'PayrollEaseDB') IS NOT NULL BEGIN " +
                           "ALTER DATABASE [PayrollEaseDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                           "DROP DATABASE [PayrollEaseDB]; END");

                    Run(c, "CREATE DATABASE [PayrollEaseDB] ON PRIMARY (NAME = N'PayrollEaseDB', FILENAME = N'" + DbFile.Replace("'", "''") + "') " +
                           "LOG ON (NAME = N'PayrollEaseDB_log', FILENAME = N'" + LogFile.Replace("'", "''") + "')");

                    // Detach so the app can attach it through AttachDbFilename
                    Run(c, "EXEC master.dbo.sp_detach_db @dbname = N'PayrollEaseDB', @skipchecks = N'true'");
                }
            }

            foreach (string sql in Schema) CUD(sql, null);

            // (ADDED) default settings, so payroll works right away
            foreach (KeyValuePair<string, string> kv in AppSettings.Defaults)
            {
                CUD("IF NOT EXISTS (SELECT 1 FROM Settings WHERE SettingKey = @k) INSERT INTO Settings (SettingKey, SettingValue) VALUES (@k, @v)",
                    new { k = kv.Key, v = kv.Value });
            }

            // (ADDED) first login account: admin / admin123
            if (Convert.ToInt32(Scalar("SELECT COUNT(*) FROM Users")) == 0)
            {
                Insert("Users", new
                {
                    Username = "admin",
                    FullName = "System Administrator",
                    Role = "Admin",
                    PasswordHash = PasswordHasher.Hash("admin123"),
                    IsActive = true
                });
            }
        }

        static void Run(SqlConnection c, string sql)
        {
            using (SqlCommand m = new SqlCommand(sql, c))
            {
                m.ExecuteNonQuery();
            }
        }

        public static string DbPath { get { return DbFile; } }

        public static string ConnectionString
        {
            get { return GetConnectionString(); }
        }

        // (ADDED) adds the properties of an anonymous object, e.g. new { Name = value }, as @Name parameters
        static void AddParams(SqlCommand c, object parameters)
        {
            if (parameters == null) return;
            foreach (PropertyInfo p in parameters.GetType().GetProperties())
            {
                object v = p.GetValue(parameters, null);
                c.Parameters.AddWithValue("@" + p.Name, v ?? DBNull.Value);
            }
        }

        static string SafeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, @"^[A-Za-z0-9_]+$"))
                throw new ArgumentException("Invalid table or column name: " + name);
            return "[" + name + "]";
        }

        // =================== from WindowsFormsAppDB/Database.cs ===================

        public void CUD(string query)
        {
            CUD(query, null);
        }

        public int CUD(string query, object parameters)
        {
            using (con = new SqlConnection(constring))
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                AddParams(cmd, parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        // db.create("Profile", "first_name, middle_name, last_name", new TextBox[] { txtFirstName, txtMiddleName, txtLastName });
        public void create(string table, string columns, TextBox[] textbox)
        {
            string[] cols = columns.Split(',');
            StringBuilder sbCols = new StringBuilder();
            StringBuilder sbVals = new StringBuilder();
            using (con = new SqlConnection(constring))
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                for (int i = 0; i < cols.Length; i++)
                {
                    if (i > 0) { sbCols.Append(", "); sbVals.Append(", "); }
                    sbCols.Append(SafeName(cols[i].Trim()));
                    sbVals.Append("@p" + i);
                    cmd.Parameters.AddWithValue("@p" + i, textbox[i].Text);
                }
                cmd.CommandText = "INSERT INTO " + SafeName(table) + " (" + sbCols + ") VALUES (" + sbVals + ")";
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Successfully saved!");
                else MessageBox.Show("Failed!");
            }
        }

        // db.update("Profile", new string[] {"first_name", "last_name"}, new TextBox[] {txtFirstName, txtLastName}, txtId)
        public void update(string table, string[] columns, TextBox[] txt, TextBox id)
        {
            StringBuilder sb = new StringBuilder();
            using (con = new SqlConnection(constring))
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.Connection = con;
                for (int i = 0; i < columns.Length; i++)
                {
                    if (i > 0) sb.Append(", ");
                    sb.Append(SafeName(columns[i]) + " = @p" + i);
                    cmd.Parameters.AddWithValue("@p" + i, txt[i].Text);
                }
                cmd.Parameters.AddWithValue("@Id", id.Text);
                cmd.CommandText = "UPDATE " + SafeName(table) + " SET " + sb + " WHERE Id = @Id";
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Successfully updated!");
                else MessageBox.Show("Failed!");
            }
        }

        public void delete(string table, TextBox txtId)
        {
            using (con = new SqlConnection(constring))
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM " + SafeName(table) + " WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("Successfully deleted!");
                else MessageBox.Show("Failed!");
            }
        }

        public DataTable select(string query)
        {
            return select(query, null);
        }

        public DataTable select(string query, object parameters)
        {
            using (con = new SqlConnection(constring))
            {
                da = new SqlDataAdapter(query, con);
                AddParams(da.SelectCommand, parameters);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // =================== (ADDED) helpers so the forms stay short ===================

        // db.Insert("Employees", new { FirstName = "Ana", LastName = "Reyes" })
        public bool Insert(string table, object values)
        {
            PropertyInfo[] props = values.GetType().GetProperties();
            StringBuilder cols = new StringBuilder();
            StringBuilder vals = new StringBuilder();
            for (int i = 0; i < props.Length; i++)
            {
                if (i > 0) { cols.Append(", "); vals.Append(", "); }
                cols.Append(SafeName(props[i].Name));
                vals.Append("@" + props[i].Name);
            }
            return CUD("INSERT INTO " + SafeName(table) + " (" + cols + ") VALUES (" + vals + ")", values) > 0;
        }

        // db.UpdateRow("Employees", new { FirstName = "Ana" }, id)
        public bool UpdateRow(string table, object values, int id)
        {
            PropertyInfo[] props = values.GetType().GetProperties();
            StringBuilder sets = new StringBuilder();
            for (int i = 0; i < props.Length; i++)
            {
                if (i > 0) sets.Append(", ");
                sets.Append(SafeName(props[i].Name) + " = @" + props[i].Name);
            }
            using (con = new SqlConnection(constring))
            {
                con.Open();
                cmd = new SqlCommand("UPDATE " + SafeName(table) + " SET " + sets + " WHERE Id = @RowId", con);
                AddParams(cmd, values);
                cmd.Parameters.AddWithValue("@RowId", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteRow(string table, int id)
        {
            return CUD("DELETE FROM " + SafeName(table) + " WHERE Id = @Id", new { Id = id }) > 0;
        }

        public DataRow GetRow(string table, int id)
        {
            DataTable dt = select("SELECT * FROM " + SafeName(table) + " WHERE Id = @Id", new { Id = id });
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public object Scalar(string query)
        {
            return Scalar(query, null);
        }

        public object Scalar(string query, object parameters)
        {
            using (con = new SqlConnection(constring))
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                AddParams(cmd, parameters);
                return cmd.ExecuteScalar();
            }
        }

        // Runs all statements in one transaction (all saved or none). Used when saving a payroll.
        public bool Transaction(List<SqlBatchItem> items)
        {
            using (con = new SqlConnection(constring))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                try
                {
                    foreach (SqlBatchItem item in items)
                    {
                        cmd = new SqlCommand(item.Sql, con, tran);
                        AddParams(cmd, item.Parameters);
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    return true;
                }
                catch (Exception)
                {
                    try { tran.Rollback(); } catch { }
                    return false;
                }
            }
        }
    }
}
