# PayrollEase - follows the teacher's zips

Windows Forms (.NET Framework 4.7.2), SQL Server LocalDB. Open `PayrollEase.sln`, press F5.
Sign in: admin / admin123.  Database file is created automatically at bin\Debug\PayrollEaseDB.mdf.

## Followed from your zips
- StudentManagementSystem: Database.Initialize() creates the .mdf + tables automatically; Form_Load calls it;
  Add / View All / Update / Delete / Clear buttons; refreshTable(), clear(), validateInputs(), hasSelected...();
  dgv_CellClick fills the text boxes; MessageBox titles "Validation Error", "Success", "Error"; try/catch.
- WindowsFormsAppDB demo: Database.cs keeps CUD, create, update, delete, select (same names).
- csharf-classes: all 6 classes are in the Classes folder; FormControls, Charts and ReportPrinter are used,
  AppDb is used by ReportsForm; AppDb.Dispose() is registered at exit.
- Forms are real designer forms (Form.cs + Form.Designer.cs + Form.resx).

## Added (not in your zips) - see the chat message for the full list
Login, Session, password hashing, Settings table, payroll/attendance logic (Core folder), Ui.cs helper,
extra Database helpers (Insert, UpdateRow, DeleteRow, GetRow, Scalar, Transaction), dashboard, reports, printing.
