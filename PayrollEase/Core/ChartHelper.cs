using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Charting = System.Windows.Forms.DataVisualization.Charting;

namespace PayrollEase
{
    /// <summary>Styled chart creation on top of red_framework.Charts (alias keeps Label unambiguous).</summary>
    public static class ChartHelper
    {
        private static void StyleAxes(Charting.Chart chart, string yFormat)
        {
            Charting.ChartArea area = chart.ChartAreas[0];
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.LineColor = Theme.Border;
            area.AxisX.MajorTickMark.Enabled = false;
            area.AxisX.LabelStyle.Font = Theme.F(8.5f);
            area.AxisX.LabelStyle.ForeColor = Theme.Muted;
            area.AxisX.Interval = 1;
            area.AxisY.MajorGrid.LineColor = Theme.Border;
            area.AxisY.LineColor = Color.Transparent;
            area.AxisY.MajorTickMark.Enabled = false;
            area.AxisY.LabelStyle.Font = Theme.F(8.5f);
            area.AxisY.LabelStyle.ForeColor = Theme.Muted;
            area.AxisY.LabelStyle.Format = yFormat;
        }

        private static void Note(Charting.Chart chart, bool empty)
        {
            chart.Titles.Clear();
            if (empty)
                chart.Titles.Add(new Charting.Title("No data yet", Charting.Docking.Top, Theme.F(10f), Theme.Muted));
        }

        public static void Column(Control host, DataTable data, string category, string value, string name, Color color)
        {
            var chart = (Charting.Chart)host;
            chart.Legends[0].Enabled = false;
            StyleAxes(chart, "N0");
            Charting.Series s = red_framework.Charts.Bind(chart, data, category, value, name, Charting.SeriesChartType.Column);
            Note(chart, s == null);
            if (s == null) return;
            s.Color = color;
            s["PointWidth"] = "0.55";
            s.IsValueShownAsLabel = true;
            s.Font = Theme.F(8.5f, FontStyle.Bold);
            s.LabelForeColor = Theme.Text;
        }

        public static void Line(Control host, DataTable data, string category, string value, string name, Color color)
        {
            var chart = (Charting.Chart)host;
            chart.Legends[0].Enabled = false;
            StyleAxes(chart, "N0");
            Charting.Series s = red_framework.Charts.Bind(chart, data, category, value, name, Charting.SeriesChartType.Line);
            Note(chart, s == null);
            if (s == null) return;
            s.Color = color;
            s.BorderWidth = 3;
            s.MarkerStyle = Charting.MarkerStyle.Circle;
            s.MarkerSize = 8;
            s.MarkerColor = color;
            s.MarkerBorderColor = Color.White;
        }
    }
}
