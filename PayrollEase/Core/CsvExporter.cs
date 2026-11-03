using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PayrollEase
{
    public static class CsvExporter
    {
        private static string Escape(string s)
        {
            if (s == null) return "";
            if (s.IndexOfAny(new[] { ',', '"', '\n', '\r' }) >= 0)
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }

        /// <summary>Asks for a file name and writes the (already formatted) table as UTF-8 CSV that Excel can open.</summary>
        public static bool Save(DataTable table, string suggestedName)
        {
            if (table == null || table.Rows.Count == 0)
            {
                Ui.Info("There is nothing to export.");
                return false;
            }
            using (var dlg = new SaveFileDialog())
            {
                dlg.Title = "Export to CSV";
                dlg.Filter = "CSV file (*.csv)|*.csv";
                dlg.FileName = suggestedName + ".csv";
                dlg.OverwritePrompt = true;
                if (dlg.ShowDialog() != DialogResult.OK) return false;

                try
                {
                    var sb = new StringBuilder();
                    for (int c = 0; c < table.Columns.Count; c++)
                    {
                        if (c > 0) sb.Append(',');
                        sb.Append(Escape(table.Columns[c].ColumnName));
                    }
                    sb.AppendLine();
                    foreach (DataRow row in table.Rows)
                    {
                        for (int c = 0; c < table.Columns.Count; c++)
                        {
                            if (c > 0) sb.Append(',');
                            sb.Append(Escape(Convert.ToString(row[c], Fmt.Ci)));
                        }
                        sb.AppendLine();
                    }
                    File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
                    return true;
                }
                catch (Exception ex)
                {
                    Ui.Error("The file could not be saved.\n\n" + ex.Message);
                    return false;
                }
            }
        }
    }
}
