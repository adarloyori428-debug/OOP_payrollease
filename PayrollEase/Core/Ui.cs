using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollEase
{
    /// <summary>Helpers used by the forms: message boxes, combo loading and grid formatting.</summary>
    public static class Ui
    {
        public const string AppTitle = "PayrollEase";

        public static void Info(string message)
        {
            MessageBox.Show(message, AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warn(string message)
        {
            MessageBox.Show(message, AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string message)
        {
            MessageBox.Show(message, AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Confirm(string message)
        {
            return MessageBox.Show(message, AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>Warns and focuses the control when it is empty. Returns true when it has a value.</summary>
        public static bool Required(Control c, string name)
        {
            if (!red_framework.FormControls.Required(c, name))
            {
                Warn(name + " is required.");
                c.Focus();
                return false;
            }
            return true;
        }

        public static void FillCombo(ComboBox cmb, DataTable dt, string display, string value)
        {
            cmb.DataSource = null;
            cmb.DisplayMember = display;
            cmb.ValueMember = value;
            cmb.DataSource = dt;
        }

        /// <summary>Selected ValueMember converted to int (0 when nothing is selected).</summary>
        public static int SelectedId(ComboBox cmb)
        {
            if (cmb.SelectedValue == null) return 0;
            int v;
            return int.TryParse(Convert.ToString(cmb.SelectedValue), out v) ? v : 0;
        }

        public static DataTable EmployeeTable(bool includeAll, bool activeOnly)
        {
            string where = activeOnly ? "WHERE IsActive = 1" : "";
            string all = includeAll ? "SELECT 0 AS Id, N'All employees' AS Name, 0 AS Sort UNION ALL " : "";
            string sql = "SELECT Id, Name FROM (" + all +
                         "SELECT Id, EmployeeNo + N' - ' + LastName + N', ' + FirstName AS Name, 1 AS Sort FROM Employees " + where +
                         ") x ORDER BY Sort, Name";
            return new Database().select(sql);
        }

        public static void Col(DataGridView g, string name, string header, string format, bool right, int width)
        {
            if (!g.Columns.Contains(name)) return;
            DataGridViewColumn c = g.Columns[name];
            c.HeaderText = header;
            if (!string.IsNullOrEmpty(format)) c.DefaultCellStyle.Format = format;
            if (right)
            {
                c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (width > 0)
            {
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                c.Width = width;
            }
        }

        public static void Col(DataGridView g, string name, string header)
        {
            Col(g, name, header, null, false, 0);
        }

        public static void HideCol(DataGridView g, string name)
        {
            if (g.Columns.Contains(name)) g.Columns[name].Visible = false;
        }

        public static void StatusColors(string status, out Color back, out Color fore)
        {
            switch (status)
            {
                case "Present":
                case "Active":
                case "Finalized":
                    back = Theme.GreenSoft; fore = Theme.GreenDark; break;
                case "Late":
                    back = Theme.AmberSoft; fore = ColorTranslator.FromHtml("#B45309"); break;
                case "Half Day":
                    back = Theme.BlueSoft; fore = ColorTranslator.FromHtml("#1D4ED8"); break;
                case "Absent":
                case "Inactive":
                    back = Theme.RedSoft; fore = Theme.RedDark; break;
                case "Leave":
                    back = Theme.VioletSoft; fore = ColorTranslator.FromHtml("#6D28D9"); break;
                default:
                    back = Theme.Soft; fore = Theme.Muted; break;
            }
        }

        /// <summary>Colors the cells of a "Status" column (Present, Late, Absent...). Call once per grid.</summary>
        public static void ColorStatus(DataGridView g, string columnName)
        {
            g.CellFormatting += delegate (object sender, DataGridViewCellFormattingEventArgs e)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                if (g.Columns[e.ColumnIndex].Name != columnName) return;
                string status = Convert.ToString(e.Value);
                if (string.IsNullOrEmpty(status)) return;
                Color back, fore;
                StatusColors(status, out back, out fore);
                e.CellStyle.BackColor = back;
                e.CellStyle.ForeColor = fore;
                e.CellStyle.SelectionBackColor = back;
                e.CellStyle.SelectionForeColor = fore;
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            };
        }

        /// <summary>Formats a table for printing/exporting: friendly header names, no Id columns, strings only.</summary>
        public static DataTable ToPrintTable(DataTable source)
        {
            var result = new DataTable();
            var keep = new List<DataColumn>();
            foreach (DataColumn c in source.Columns)
            {
                if (c.ColumnName == "Id" || c.ColumnName.EndsWith("Id", StringComparison.Ordinal)) continue;
                keep.Add(c);
                result.Columns.Add(c.Caption, typeof(string));
            }
            foreach (DataRow row in source.Rows)
            {
                var values = new object[keep.Count];
                for (int i = 0; i < keep.Count; i++)
                {
                    object v = row[keep[i]];
                    if (v == null || v is DBNull) values[i] = "";
                    else if (v is decimal) values[i] = ((decimal)v).ToString("N2", Fmt.Ci);
                    else if (v is double) values[i] = ((double)v).ToString("N2", Fmt.Ci);
                    else if (v is DateTime)
                    {
                        var d = (DateTime)v;
                        values[i] = d.TimeOfDay == TimeSpan.Zero ? d.ToString("MMM dd, yyyy", Fmt.Ci) : d.ToString("hh:mm tt", Fmt.Ci);
                    }
                    else if (v is bool) values[i] = ((bool)v) ? "Yes" : "No";
                    else values[i] = Convert.ToString(v, Fmt.Ci);
                }
                result.Rows.Add(values);
            }
            return result;
        }
    }
}
