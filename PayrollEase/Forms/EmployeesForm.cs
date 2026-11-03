using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PayrollEase
{
    public partial class EmployeesForm : Form, IRefreshable
    {
        Database db = new Database();
        bool loading;

        public EmployeesForm()
        {
            InitializeComponent();
            Ui.ColorStatus(dgvEmployees, "Status");   // (ADDED) colored Status cells
            cmbStatus.SelectedIndex = 0;
            cmbPayType.SelectedIndex = 0;
            clear();
        }

        // (ADDED) MainForm calls this every time this page is shown, so the table is always up to date
        public void RefreshData()
        {
            loadDepartments();
            refreshTable();
            if (txtEmployeeID.Text == "") txtEmployeeNo.Text = nextEmployeeNo();
        }

        // ---------- helpers ----------

        string nextEmployeeNo()
        {
            int n = Fmt.I(db.Scalar("SELECT ISNULL(MAX(Id), 0) FROM Employees")) + 1;
            string no;
            do
            {
                no = "EMP-" + n.ToString("D4");
                n++;
            } while (Fmt.I(db.Scalar("SELECT COUNT(*) FROM Employees WHERE EmployeeNo = @n", new { n = no })) > 0);
            return no;
        }

        void loadDepartments()
        {
            loading = true;
            try
            {
                DataTable dt = db.select("SELECT DISTINCT Department FROM Employees WHERE Department <> N'' ORDER BY Department");
                List<string> names = new List<string>();
                foreach (DataRow r in dt.Rows) names.Add(Fmt.S(r["Department"]));

                string keepFilter = cmbDeptFilter.Text;
                cmbDeptFilter.Items.Clear();
                cmbDeptFilter.Items.Add("All");
                foreach (string n in names) cmbDeptFilter.Items.Add(n);
                int idx = cmbDeptFilter.FindStringExact(keepFilter);
                cmbDeptFilter.SelectedIndex = idx >= 0 ? idx : 0;

                string keepDept = cmbDepartment.Text;
                cmbDepartment.Items.Clear();
                foreach (string n in names) cmbDepartment.Items.Add(n);
                foreach (string d in new string[] { "Administration", "Operations", "Sales", "Finance", "Production" })
                    if (!cmbDepartment.Items.Contains(d)) cmbDepartment.Items.Add(d);
                cmbDepartment.Text = keepDept;
            }
            finally
            {
                loading = false;
            }
        }

        void refreshTable()
        {
            string q = txtSearch.Text.Trim();
            string dept = cmbDeptFilter.Text;
            if (dept == "") dept = "All";

            DataTable dt = db.select(
                "SELECT Id, EmployeeNo, LastName + N', ' + FirstName + CASE WHEN MiddleName = N'' THEN N'' ELSE N' ' + LEFT(MiddleName, 1) + N'.' END AS FullName, " +
                "Position, Department, PayType, Rate, CASE WHEN IsActive = 1 THEN N'Active' ELSE N'Inactive' END AS Status " +
                "FROM Employees WHERE (@q = N'' OR EmployeeNo LIKE @like OR FirstName LIKE @like OR LastName LIKE @like OR Position LIKE @like) " +
                "AND (@dept = N'All' OR Department = @dept) AND (@inactive = 1 OR IsActive = 1) ORDER BY LastName, FirstName",
                new { q = q, like = "%" + q + "%", dept = dept, inactive = chkInactive.Checked ? 1 : 0 });

            dgvEmployees.DataSource = dt;

            dgvEmployees.Columns["Id"].Visible = false;
            dgvEmployees.Columns["EmployeeNo"].HeaderText = "ID";
            dgvEmployees.Columns["FullName"].HeaderText = "Employee";
            dgvEmployees.Columns["PayType"].HeaderText = "Pay Type";
            dgvEmployees.Columns["Rate"].DefaultCellStyle.Format = "N2";
            dgvEmployees.ClearSelection();
            lblCount.Text = dt.Rows.Count + (dt.Rows.Count == 1 ? " employee" : " employees");
        }

        void clear()
        {
            red_framework.FormControls.ClearInputs(pnlFields);   // csharf-classes FormControls
            cmbStatus.SelectedIndex = 0;
            cmbPayType.SelectedIndex = 0;
            dtpDateHired.Value = DateTime.Today;
            txtRate.Text = "0.00";
            txtAllowance.Text = "0.00";
            txtEmployeeNo.Text = nextEmployeeNo();
            dgvEmployees.ClearSelection();
            txtFirstName.Focus();
        }

        // Checks empty fields, Rate and Allowance. Returns false (and shows a message) if invalid.
        bool validateInputs(out decimal rate, out decimal allowance)
        {
            rate = 0m;
            allowance = 0m;

            if (txtEmployeeNo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the Employee Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeNo.Focus();
                return false;
            }

            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the employee's First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the employee's Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            if (!Fmt.TryMoney(txtRate.Text, out rate) || rate < 0m)
            {
                MessageBox.Show("Rate must be a number (0 or higher).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRate.Focus();
                return false;
            }

            if (txtAllowance.Text.Trim() != "" && (!Fmt.TryMoney(txtAllowance.Text, out allowance) || allowance < 0m))
            {
                MessageBox.Show("Allowance must be a number (0 or higher).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAllowance.Focus();
                return false;
            }

            string email = txtEmail.Text.Trim();
            if (email != "" && (email.IndexOf('@') < 1 || email.IndexOf('.', email.IndexOf('@')) < 0))
            {
                MessageBox.Show("The email address does not look valid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        bool hasSelectedEmployee(string action)
        {
            if (txtEmployeeID.Text == "")
            {
                MessageBox.Show("Please select an employee from the table first to " + action + ".", "No Employee Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        object employeeValues(decimal rate, decimal allowance)
        {
            return new
            {
                EmployeeNo = txtEmployeeNo.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                MiddleName = txtMiddleName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Position = txtPosition.Text.Trim(),
                Department = cmbDepartment.Text.Trim(),
                ContactNumber = txtContact.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                DateHired = dtpDateHired.Value.Date,
                PayType = cmbPayType.Text,
                Rate = rate,
                Allowance = allowance,
                SSSNo = txtSSSNo.Text.Trim(),
                PhilHealthNo = txtPhilHealthNo.Text.Trim(),
                PagIbigNo = txtPagIbigNo.Text.Trim(),
                TIN = txtTIN.Text.Trim(),
                IsActive = cmbStatus.SelectedIndex <= 0
            };
        }

        // true when another employee already uses this Employee Number
        bool employeeNoTaken(int ownId)
        {
            return Fmt.I(db.Scalar("SELECT COUNT(*) FROM Employees WHERE EmployeeNo = @n AND Id <> @id",
                new { n = txtEmployeeNo.Text.Trim(), id = ownId })) > 0;
        }

        // ---------- search / filter (ADDED) ----------

        private void txtSearch_TextChanged(object sender, EventArgs e) { if (!loading) refreshTable(); }
        private void cmbDeptFilter_SelectedIndexChanged(object sender, EventArgs e) { if (!loading) refreshTable(); }
        private void chkInactive_CheckedChanged(object sender, EventArgs e) { if (!loading) refreshTable(); }

        // ---------- button events ----------

        // 1. Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal rate, allowance;

            if (!validateInputs(out rate, out allowance))
                return;

            if (employeeNoTaken(0))
            {
                MessageBox.Show("Employee Number \"" + txtEmployeeNo.Text.Trim() + "\" is already used.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeNo.Focus();
                return;
            }

            try
            {
                if (db.Insert("Employees", employeeValues(rate, allowance)))
                {
                    MessageBox.Show("Employee record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDepartments();
                    refreshTable();
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to save the employee record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. View
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Clear();
                chkInactive.Checked = true;
                cmbDeptFilter.SelectedIndex = 0;
                refreshTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!hasSelectedEmployee("update"))
                return;

            decimal rate, allowance;

            if (!validateInputs(out rate, out allowance))
                return;

            int id = Convert.ToInt32(txtEmployeeID.Text);
            if (employeeNoTaken(id))
            {
                MessageBox.Show("Employee Number \"" + txtEmployeeNo.Text.Trim() + "\" is already used by another employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeNo.Focus();
                return;
            }

            try
            {
                if (db.UpdateRow("Employees", employeeValues(rate, allowance), id))
                {
                    MessageBox.Show("Employee record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDepartments();
                    refreshTable();
                    clear();
                }
                else
                {
                    MessageBox.Show("Update failed. The record may no longer exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!hasSelectedEmployee("delete"))
                return;

            int id = Convert.ToInt32(txtEmployeeID.Text);

            try
            {
                // (ADDED) an employee that already has attendance / payroll records cannot be deleted (it would break the payroll history)
                int used = Fmt.I(db.Scalar(
                    "SELECT (SELECT COUNT(*) FROM Attendance WHERE EmployeeId = @id) + (SELECT COUNT(*) FROM Payslips WHERE EmployeeId = @id) + (SELECT COUNT(*) FROM Adjustments WHERE EmployeeId = @id)",
                    new { id = id }));

                if (used > 0)
                {
                    DialogResult inactive = MessageBox.Show(
                        "This employee already has attendance or payroll records, so the record cannot be deleted.\n\nMark the employee as Inactive instead?",
                        "Cannot Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (inactive != DialogResult.Yes)
                        return;

                    db.CUD("UPDATE Employees SET IsActive = 0 WHERE Id = @id", new { id = id });
                    MessageBox.Show("Employee set to Inactive.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshTable();
                    clear();
                    return;
                }

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this employee record?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                if (db.DeleteRow("Employees", id))
                {
                    MessageBox.Show("Employee record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDepartments();
                    refreshTable();
                    clear();
                }
                else
                {
                    MessageBox.Show("Delete failed. The record may no longer exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5. Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        // Click a row in the DataGridView -> fill the text boxes
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
            DataRow r = db.GetRow("Employees", Convert.ToInt32(row.Cells["Id"].Value));   // (ADDED) the table only shows some columns, so load the rest
            if (r == null)
                return;

            txtEmployeeID.Text = r["Id"].ToString();
            txtEmployeeNo.Text = Fmt.S(r["EmployeeNo"]);
            txtFirstName.Text = Fmt.S(r["FirstName"]);
            txtMiddleName.Text = Fmt.S(r["MiddleName"]);
            txtLastName.Text = Fmt.S(r["LastName"]);
            txtPosition.Text = Fmt.S(r["Position"]);
            cmbDepartment.Text = Fmt.S(r["Department"]);
            txtContact.Text = Fmt.S(r["ContactNumber"]);
            txtEmail.Text = Fmt.S(r["Email"]);
            txtAddress.Text = Fmt.S(r["Address"]);
            DateTime? hired = Fmt.Dt(r["DateHired"]);
            dtpDateHired.Value = hired ?? DateTime.Today;
            int pt = cmbPayType.FindStringExact(Fmt.S(r["PayType"]));
            cmbPayType.SelectedIndex = pt >= 0 ? pt : 0;
            txtRate.Text = Fmt.D(r["Rate"]).ToString("0.00", Fmt.Ci);
            txtAllowance.Text = Fmt.D(r["Allowance"]).ToString("0.00", Fmt.Ci);
            txtSSSNo.Text = Fmt.S(r["SSSNo"]);
            txtPhilHealthNo.Text = Fmt.S(r["PhilHealthNo"]);
            txtPagIbigNo.Text = Fmt.S(r["PagIbigNo"]);
            txtTIN.Text = Fmt.S(r["TIN"]);
            cmbStatus.SelectedIndex = Fmt.B(r["IsActive"]) ? 0 : 1;
        }
    }
}
