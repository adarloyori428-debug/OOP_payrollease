using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PayrollEase
{
    /// <summary>Draws and previews printable payslips (one per page).</summary>
    public static class PayslipPrinter
    {
        public static void Preview(IList<PayLine> lines, DateTime start, DateTime end, DateTime payDate)
        {
            if (lines == null || lines.Count == 0)
            {
                Ui.Info("There are no payslips to print.");
                return;
            }
            using (PrintDocument doc = Build(lines, start, end, payDate))
            using (var dlg = new PrintPreviewDialog())
            {
                dlg.Document = doc;
                dlg.Width = 960;
                dlg.Height = 760;
                dlg.StartPosition = FormStartPosition.CenterScreen;
                dlg.Text = "Payslip preview";
                dlg.ShowDialog();
            }
        }

        private static PrintDocument Build(IList<PayLine> lines, DateTime start, DateTime end, DateTime payDate)
        {
            var doc = new PrintDocument();
            doc.DocumentName = "Payslips " + Fmt.Period(start, end);
            doc.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
            int index = 0;
            doc.PrintPage += delegate (object sender, PrintPageEventArgs e)
            {
                DrawSlip(e.Graphics, e.MarginBounds, lines[index], start, end, payDate);
                index++;
                e.HasMorePages = index < lines.Count;
            };
            return doc;
        }

        private static void Row(Graphics g, string label, string value, float x, float y, float w, Font f, Color labelColor, Color valueColor)
        {
            Theme.DrawText(g, label, f, labelColor, new RectangleF(x, y, w * 0.62f, 18), StringAlignment.Near, StringAlignment.Center);
            Theme.DrawText(g, value, f, valueColor, new RectangleF(x + w * 0.5f, y, w * 0.5f, 18), StringAlignment.Far, StringAlignment.Center);
        }

        private static void DrawSlip(Graphics g, Rectangle r, PayLine l, DateTime start, DateTime end, DateTime payDate)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float x = r.Left;
            float w = r.Width;
            float y = r.Top;

            using (Font fTitle = Theme.F(20f, FontStyle.Bold))
            using (Font fBold = Theme.F(10f, FontStyle.Bold))
            using (Font fNorm = Theme.F(10f))
            using (Font fSmall = Theme.F(8.5f))
            using (Font fSection = Theme.F(9f, FontStyle.Bold))
            using (Font fNet = Theme.F(18f, FontStyle.Bold))
            {
                // header band
                var band = new RectangleF(x, y, w, 78);
                using (var br = new LinearGradientBrush(band, Theme.Navy, Theme.TealDark, 0f))
                    g.FillRectangle(br, band);
                Theme.DrawText(g, AppSettings.Company, fTitle, Color.White, new RectangleF(x + 18, y + 8, w * 0.65f, 36), StringAlignment.Near, StringAlignment.Center);
                string addr = AppSettings.Get("CompanyAddress");
                if (addr.Length > 0)
                    Theme.DrawText(g, addr, fSmall, Color.FromArgb(220, 255, 255, 255), new RectangleF(x + 18, y + 46, w * 0.65f, 20), StringAlignment.Near, StringAlignment.Center);
                Theme.DrawText(g, "PAYSLIP", fTitle, Theme.TealSoft, new RectangleF(x + w * 0.55f, y + 8, w * 0.45f - 18, 36), StringAlignment.Far, StringAlignment.Center);
                Theme.DrawText(g, Fmt.Period(start, end), fNorm, Color.White, new RectangleF(x + w * 0.45f, y + 46, w * 0.55f - 18, 20), StringAlignment.Far, StringAlignment.Center);
                y += 96;

                // employee box
                var box = new RectangleF(x, y, w, 92);
                using (GraphicsPath p = Theme.RoundRect(box, 8f))
                {
                    using (var fill = new SolidBrush(Theme.Soft)) g.FillPath(fill, p);
                    using (var pen = new Pen(Theme.Border)) g.DrawPath(pen, p);
                }
                float half = (w - 40) / 2f;
                Row(g, "Employee", l.Name, x + 16, y + 10, half, fNorm, Theme.Muted, Theme.Text);
                Row(g, "Employee No.", l.EmployeeNo, x + 16, y + 32, half, fNorm, Theme.Muted, Theme.Text);
                Row(g, "Position", l.Position.Length > 0 ? l.Position : "-", x + 16, y + 54, half, fNorm, Theme.Muted, Theme.Text);
                string rateText = l.PayType + " - " + Fmt.Money(l.Rate);
                Row(g, "Pay basis", rateText, x + 24 + half, y + 10, half, fNorm, Theme.Muted, Theme.Text);
                Row(g, "Department", l.Department.Length > 0 ? l.Department : "-", x + 24 + half, y + 32, half, fNorm, Theme.Muted, Theme.Text);
                Row(g, "Pay date", payDate.ToString("MMM dd, yyyy", Fmt.Ci), x + 24 + half, y + 54, half, fNorm, Theme.Muted, Theme.Text);
                y += 108;

                // attendance summary
                Theme.DrawText(g, "ATTENDANCE SUMMARY", fSection, Theme.TealDark, new RectangleF(x, y, w, 18), StringAlignment.Near, StringAlignment.Center);
                y += 22;
                float cell = w / 4f;
                string[] caps = { "Days paid", "Hours worked", "Overtime (hrs)", "Late / undertime (min)" };
                string[] vals =
                {
                    l.DaysPaid.ToString("0.##", Fmt.Ci),
                    l.HoursWorked.ToString("0.00", Fmt.Ci),
                    l.OvertimeHours.ToString("0.00", Fmt.Ci),
                    (l.LateMinutes + l.UndertimeMinutes).ToString(Fmt.Ci)
                };
                for (int i = 0; i < 4; i++)
                {
                    Theme.DrawText(g, caps[i], fSmall, Theme.Muted, new RectangleF(x + i * cell, y, cell - 6, 16), StringAlignment.Near, StringAlignment.Center);
                    Theme.DrawText(g, vals[i], fBold, Theme.Text, new RectangleF(x + i * cell, y + 16, cell - 6, 20), StringAlignment.Near, StringAlignment.Center);
                }
                y += 50;

                // earnings / deductions
                float colW = (w - 30) / 2f;
                float leftX = x;
                float rightX = x + colW + 30;
                using (var pen = new Pen(Theme.Border))
                    g.DrawLine(pen, x + colW + 15, y, x + colW + 15, y + 214);

                Theme.DrawText(g, "EARNINGS", fSection, Theme.TealDark, new RectangleF(leftX, y, colW, 18), StringAlignment.Near, StringAlignment.Center);
                Theme.DrawText(g, "DEDUCTIONS", fSection, Theme.RedDark, new RectangleF(rightX, y, colW, 18), StringAlignment.Near, StringAlignment.Center);
                float ey = y + 26;
                Row(g, "Basic pay", Fmt.Money(l.BasicPay), leftX, ey, colW, fNorm, Theme.Muted, Theme.Text); ey += 24;
                Row(g, "Overtime pay", Fmt.Money(l.OvertimePay), leftX, ey, colW, fNorm, Theme.Muted, Theme.Text); ey += 24;
                Row(g, "Allowance", Fmt.Money(l.Allowance), leftX, ey, colW, fNorm, Theme.Muted, Theme.Text); ey += 24;
                Row(g, "Other earnings", Fmt.Money(l.OtherEarnings), leftX, ey, colW, fNorm, Theme.Muted, Theme.Text); ey += 34;
                using (var pen = new Pen(Theme.FieldBorder)) g.DrawLine(pen, leftX, ey - 6, leftX + colW, ey - 6);
                Row(g, "Gross pay", Fmt.Money(l.GrossPay), leftX, ey, colW, fBold, Theme.Text, Theme.Text);

                float dy = y + 26;
                Row(g, "Late / undertime", Fmt.Money(l.LateDeduction), rightX, dy, colW, fNorm, Theme.Muted, Theme.Text); dy += 24;
                Row(g, "SSS", Fmt.Money(l.SSS), rightX, dy, colW, fNorm, Theme.Muted, Theme.Text); dy += 24;
                Row(g, "PhilHealth", Fmt.Money(l.PhilHealth), rightX, dy, colW, fNorm, Theme.Muted, Theme.Text); dy += 24;
                Row(g, "Pag-IBIG", Fmt.Money(l.PagIbig), rightX, dy, colW, fNorm, Theme.Muted, Theme.Text); dy += 24;
                Row(g, "Withholding tax", Fmt.Money(l.Tax), rightX, dy, colW, fNorm, Theme.Muted, Theme.Text); dy += 24;
                Row(g, "Other deductions", Fmt.Money(l.OtherDeductions), rightX, dy, colW, fNorm, Theme.Muted, Theme.Text); dy += 34;
                using (var pen = new Pen(Theme.FieldBorder)) g.DrawLine(pen, rightX, dy - 6, rightX + colW, dy - 6);
                Row(g, "Total deductions", Fmt.Money(l.TotalDeductions), rightX, dy, colW, fBold, Theme.Text, Theme.RedDark);
                y += 232;

                // net pay
                var net = new RectangleF(x, y, w, 64);
                using (GraphicsPath np = Theme.RoundRect(net, 10f))
                using (var br = new LinearGradientBrush(net, Theme.TealDark, Theme.Teal, 0f))
                    g.FillPath(br, np);
                Theme.DrawText(g, "NET PAY", fBold, Color.White, new RectangleF(x + 20, y, w * 0.4f, 64), StringAlignment.Near, StringAlignment.Center);
                Theme.DrawText(g, Fmt.Money(l.NetPay), fNet, Color.White, new RectangleF(x + w * 0.35f, y, w * 0.65f - 20, 64), StringAlignment.Far, StringAlignment.Center);
                y += 100;

                // signatures
                using (var pen = new Pen(Theme.Muted))
                {
                    g.DrawLine(pen, x, y + 30, x + w * 0.4f, y + 30);
                    g.DrawLine(pen, x + w * 0.6f, y + 30, x + w, y + 30);
                }
                Theme.DrawText(g, "Prepared by", fSmall, Theme.Muted, new RectangleF(x, y + 34, w * 0.4f, 16), StringAlignment.Near, StringAlignment.Center);
                Theme.DrawText(g, "Received by (employee)", fSmall, Theme.Muted, new RectangleF(x + w * 0.6f, y + 34, w * 0.4f, 16), StringAlignment.Near, StringAlignment.Center);
                Theme.DrawText(g, "This payslip was generated by PayrollEase.", fSmall, Theme.Muted, new RectangleF(x, y + 70, w, 16), StringAlignment.Center, StringAlignment.Center);
            }
        }
    }
}
