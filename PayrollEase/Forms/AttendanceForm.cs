using System;
using System.Data;
using System.Windows.Forms;

namespace PayrollEase
{
    public partial class AttendanceForm : Form, IRefreshable
    {
        Database db = new Database();
        bool loading;
        bool statusHooked;

        public AttendanceForm()
        {
            InitializeComponent();
            loading = true;
            DateTime today = DateTime.Today;
            dtpFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpTo.Value = today;
            cmbStatusFilter.SelectedIndex = 0;
            cmbEntryMode.SelectedIndex = 0;
            loading = false;
            clear();
            lblBigClock.Text = DateTime.Now.ToString("hh:mm:ss tt", Fmt.Ci);
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblBigClock.Text = DateTime.Now.ToString("hh:mm:ss tt", Fmt.Ci);
        }

        public void RefreshData()
        {
            loading = true;
            try
            {
                int punchSel = Ui.SelectedId(cmbPunchEmployee);
                Ui.FillCombo(cmbPunchEmployee, Ui.EmployeeTable(false, true), "Name", "Id");
                if (punchSel > 0) cmbPunchEmployee.SelectedValue = punchSel;

                int filterSel = Ui.SelectedId(cmbEmployeeFilter);
                Ui.FillCombo(cmbEmployeeFilter, Ui.EmployeeTable(true, false), "Name", "Id");
                cmbEmployeeFilter.SelectedValue = filterSel;
                if (cmbEmployeeFilter.SelectedIndex < 0 && cmbEmployeeFilter.Items.Count > 0) cmbEmployeeFilter.SelectedIndex = 0;

                int entrySel = Ui.SelectedId(cmbEntryEmployee);
                Ui.FillCombo(cmbEntryEmployee, Ui.EmployeeTable(false, false), "Name", "Id");
                if (entrySel > 0) cmbEntryEmployee.SelectedValue = entrySel;
            }
            finally
            {
                loading = false;
            }

            TimeSpan start = AppSettings.GetTime("WorkStart");
            TimeSpan end = AppSettings.GetTime("WorkEnd");
            lblRules.Text =
                "Shift:  " + DateTime.Today.Add(start).ToString("hh:mm tt", Fmt.Ci) + " - " + DateTime.Today.Add(end).ToString("hh:mm tt", Fmt.Ci) +
                "      Break:  " + AppSettings.GetDecimal("BreakHours").ToString("0.##", Fmt.Ci) + " hr\n" +
                "Late after:  " + AppSettings.GetInt("GraceMinutes") + " min grace\n" +
                "Overtime counts after:  " + AppSettings.GetInt("MinOvertimeMinutes") + " min past shift end\n" +
                "Half day when worked under:  " + AppSettings.GetDecimal("HalfDayHours").ToString("0.##", Fmt.Ci) + " hrs";
            refreshTable();
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            if (!loading) refreshTable();
        }

        private void refreshTable()
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date) return;
            string status = cmbStatusFilter.Text;
            if (string.IsNullOrEmpty(status)) status = "All";

            DataTable dt = db.select(
                "SELECT a.Id, a.WorkDate, e.EmployeeNo, e.LastName + N', ' + e.FirstName AS Employee, a.TimeIn, a.TimeOut, " +
                "a.HoursWorked, a.LateMinutes, a.UndertimeMinutes, a.OvertimeHours, a.Status, a.Remarks " +
                "FROM Attendance a INNER JOIN Employees e ON e.Id = a.EmployeeId " +
                "WHERE a.WorkDate BETWEEN @f AND @t AND (@emp = 0 OR a.EmployeeId = @emp) AND (@st = N'All' OR a.Status = @st) " +
                "ORDER BY a.WorkDate DESC, e.LastName, e.FirstName",
                new { f = dtpFrom.Value.Date, t = dtpTo.Value.Date, emp = Ui.SelectedId(cmbEmployeeFilter), st = status });

            loading = true;
            try
            {
                dgvAttendance.DataSource = dt;
                Ui.HideCol(dgvAttendance, "Id");
                Ui.Col(dgvAttendance, "WorkDate", "Date", "MMM dd, yyyy", false, 120);
                Ui.Col(dgvAttendance, "EmployeeNo", "ID", null, false, 90);
                Ui.Col(dgvAttendance, "Employee", "Employee");
                Ui.Col(dgvAttendance, "TimeIn", "Time in", "hh:mm tt", false, 95);
                Ui.Col(dgvAttendance, "TimeOut", "Time out", "hh:mm tt", false, 95);
                Ui.Col(dgvAttendance, "HoursWorked", "Hours", "N2", true, 75);
                Ui.Col(dgvAttendance, "LateMinutes", "Late (min)", null, true, 85);
                Ui.Col(dgvAttendance, "UndertimeMinutes", "Undertime", null, true, 90);
                Ui.Col(dgvAttendance, "OvertimeHours", "OT hrs", "N2", true, 75);
                Ui.Col(dgvAttendance, "Status", "Status", null, false, 100);
                Ui.Col(dgvAttendance, "Remarks", "Remarks");
                if (!statusHooked)
                {
                    Ui.ColorStatus(dgvAttendance, "Status");
                    statusHooked = true;
                }
                dgvAttendance.ClearSelection();
            }
            finally
            {
                loading = false;
            }
        }

        // ---------- quick punch ----------
        private void SetResult(string message, bool good)
        {
            lblPunchResult.Text = message;
            lblPunchResult.ForeColor = good ? Theme.GreenDark : Theme.RedDark;
        }

        private string PunchName()
        {
            string name = cmbPunchEmployee.Text;
            int dash = name.IndexOf(" - ", StringComparison.Ordinal);
            return dash >= 0 ? name.Substring(dash + 3) : name;
        }

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            int emp = Ui.SelectedId(cmbPunchEmployee);
            if (emp <= 0) { Ui.Warn("Please select an employee first."); return; }

            DateTime now = DateTime.Now;
            DateTime today = now.Date;
            string name = PunchName();
            DataTable existing = db.select("SELECT Id, TimeIn, TimeOut FROM Attendance WHERE EmployeeId = @e AND WorkDate = @d", new { e = emp, d = today });
            DataRow row = existing.Rows.Count > 0 ? existing.Rows[0] : null;

            if (row != null && Fmt.Dt(row["TimeIn"]).HasValue)
            {
                SetResult(name + " already timed in at " + Fmt.Dt(row["TimeIn"]).Value.ToString("hh:mm tt", Fmt.Ci) + ".", false);
                return;
            }

            AttendanceResult r = AttendanceCalc.Compute(today, now, null, null);
            bool ok;
            if (row == null)
            {
                ok = db.Insert("Attendance", new
                {
                    EmployeeId = emp,
                    WorkDate = today,
                    TimeIn = (DateTime?)now,
                    TimeOut = (DateTime?)null,
                    HoursWorked = r.Hours,
                    LateMinutes = r.Late,
                    UndertimeMinutes = r.Under,
                    OvertimeHours = r.Overtime,
                    Status = r.Status,
                    Remarks = ""
                });
            }
            else
            {
                ok = db.UpdateRow("Attendance", new
                {
                    TimeIn = (DateTime?)now,
                    TimeOut = (DateTime?)null,
                    HoursWorked = r.Hours,
                    LateMinutes = r.Late,
                    UndertimeMinutes = r.Under,
                    OvertimeHours = r.Overtime,
                    Status = r.Status
                }, Fmt.I(row["Id"]));
            }
            if (!ok) { SetResult("Time in could not be saved.", false); return; }
            string late = r.Late > 0 ? " (late by " + r.Late + " min)" : "";
            SetResult(name + " timed in at " + now.ToString("hh:mm tt", Fmt.Ci) + late + ".", true);
            refreshTable();
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            int emp = Ui.SelectedId(cmbPunchEmployee);
            if (emp <= 0) { Ui.Warn("Please select an employee first."); return; }

            DateTime now = DateTime.Now;
            DateTime today = now.Date;
            string name = PunchName();
            DataTable existing = db.select("SELECT Id, TimeIn, TimeOut FROM Attendance WHERE EmployeeId = @e AND WorkDate = @d", new { e = emp, d = today });
            DataRow row = existing.Rows.Count > 0 ? existing.Rows[0] : null;

            if (row == null || !Fmt.Dt(row["TimeIn"]).HasValue)
            {
                SetResult(name + " has no time in today. Use the manual entry below.", false);
                return;
            }
            if (Fmt.Dt(row["TimeOut"]).HasValue)
            {
                SetResult(name + " already timed out at " + Fmt.Dt(row["TimeOut"]).Value.ToString("hh:mm tt", Fmt.Ci) + ".", false);
                return;
            }
            DateTime tin = Fmt.Dt(row["TimeIn"]).Value;
            if ((now - tin).TotalMinutes < 1)
            {
                SetResult("Please wait at least a minute after timing in.", false);
                return;
            }

            AttendanceResult r = AttendanceCalc.Compute(today, tin, now, null);
            bool ok = db.UpdateRow("Attendance", new
            {
                TimeOut = (DateTime?)now,
                HoursWorked = r.Hours,
                LateMinutes = r.Late,
                UndertimeMinutes = r.Under,
                OvertimeHours = r.Overtime,
                Status = r.Status
            }, Fmt.I(row["Id"]));
            if (!ok) { SetResult("Time out could not be saved.", false); return; }
            SetResult(name + " timed out at " + now.ToString("hh:mm tt", Fmt.Ci) + " (" + r.Hours.ToString("0.00", Fmt.Ci) + " hrs).", true);
            refreshTable();
        }

        // ---------- manual entry (same pattern as StudentManagementSystem: Add / Update / Delete / Clear) ----------

        void clear()
        {
            txtRecordID.Clear();
            dtpEntryDate.Value = DateTime.Today;
            cmbEntryMode.SelectedIndex = 0;
            dtpTimeIn.Value = DateTime.Today.AddHours(8);
            dtpTimeOut.Value = DateTime.Today.AddHours(17);
            dtpTimeIn.Checked = true;
            dtpTimeOut.Checked = true;
            txtRemarks.Clear();
            cmbEntryEmployee.Enabled = true;
            dgvAttendance.ClearSelection();
        }

        bool hasSelectedRecord(string action)
        {
            if (txtRecordID.Text == "")
            {
                MessageBox.Show("Please select a record from the table first to " + action + ".", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Checks the entry fields. Returns false (and shows a message) if invalid. Builds the values to save.
        bool validateInputs(int ownId, out object values)
        {
            values = null;
            int empId = Ui.SelectedId(cmbEntryEmployee);
            if (empId <= 0)
            {
                MessageBox.Show("Please choose an employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbEntryEmployee.Focus();
                return false;
            }

            DateTime date = dtpEntryDate.Value.Date;
            if (date > DateTime.Today.AddDays(1))
            {
                MessageBox.Show("The date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool auto = cmbEntryMode.SelectedIndex <= 0;
            DateTime? tin = null;
            DateTime? tout = null;
            if (auto)
            {
                if (!dtpTimeIn.Checked)
                {
                    MessageBox.Show("Enter a time in, or choose the Absent / Leave status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                tin = date + dtpTimeIn.Value.TimeOfDay;
                if (dtpTimeOut.Checked)
                {
                    tout = date + dtpTimeOut.Value.TimeOfDay;
                    if (tout.Value <= tin.Value)
                    {
                        MessageBox.Show("Time out must be later than time in.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            int dup = Fmt.I(db.Scalar("SELECT COUNT(*) FROM Attendance WHERE EmployeeId = @e AND WorkDate = @d AND Id <> @id",
                new { e = empId, d = date, id = ownId }));
            if (dup > 0)
            {
                MessageBox.Show("A record already exists for this employee on that date. Click it in the table to edit it.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string forced = auto ? null : (cmbEntryMode.SelectedIndex == 1 ? "Absent" : "Leave");
            AttendanceResult r = AttendanceCalc.Compute(date, tin, tout, forced);

            values = new
            {
                EmployeeId = empId,
                WorkDate = date,
                TimeIn = tin,
                TimeOut = tout,
                HoursWorked = r.Hours,
                LateMinutes = r.Late,
                UndertimeMinutes = r.Under,
                OvertimeHours = r.Overtime,
                Status = r.Status,
                Remarks = txtRemarks.Text.Trim()
            };
            return true;
        }

        private void cmbEntryMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool auto = cmbEntryMode.SelectedIndex <= 0;
            dtpTimeIn.Enabled = auto;
            dtpTimeOut.Enabled = auto;
        }

        // 1. Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            object values;
            if (!validateInputs(0, out values))
                return;

            try
            {
                if (db.Insert("Attendance", values))
                {
                    MessageBox.Show("Attendance record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshTable();
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to save the attendance record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!hasSelectedRecord("update"))
                return;

            int id = Convert.ToInt32(txtRecordID.Text);
            object values;
            if (!validateInputs(id, out values))
                return;

            try
            {
                if (db.UpdateRow("Attendance", values, id))
                {
                    MessageBox.Show("Attendance record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!hasSelectedRecord("delete"))
                return;

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this attendance record?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                if (db.DeleteRow("Attendance", Convert.ToInt32(txtRecordID.Text)))
                {
                    MessageBox.Show("Attendance record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Click a row in the DataGridView -> fill the entry boxes
        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dgvAttendance.Rows[e.RowIndex].Cells["Id"].Value);
            DataRow r = db.GetRow("Attendance", id);
            if (r == null)
                return;

            txtRecordID.Text = id.ToString();
            cmbEntryEmployee.SelectedValue = Fmt.I(r["EmployeeId"]);
            cmbEntryEmployee.Enabled = false;
            DateTime? wd = Fmt.Dt(r["WorkDate"]);
            dtpEntryDate.Value = wd ?? DateTime.Today;
            string status = Fmt.S(r["Status"]);
            cmbEntryMode.SelectedIndex = status == "Absent" ? 1 : (status == "Leave" ? 2 : 0);
            DateTime? tin = Fmt.Dt(r["TimeIn"]);
            DateTime? tout = Fmt.Dt(r["TimeOut"]);
            if (tin.HasValue) { dtpTimeIn.Value = tin.Value; dtpTimeIn.Checked = true; } else dtpTimeIn.Checked = false;
            if (tout.HasValue) { dtpTimeOut.Value = tout.Value; dtpTimeOut.Checked = true; } else dtpTimeOut.Checked = false;
            txtRemarks.Text = Fmt.S(r["Remarks"]);
        }
    }
}
