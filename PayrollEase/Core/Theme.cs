using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace PayrollEase
{
    /// <summary>Colors, fonts and small drawing helpers shared by every screen.</summary>
    public static class Theme
    {
        public static readonly Color Navy = ColorTranslator.FromHtml("#0B1426");
        public static readonly Color NavyLight = ColorTranslator.FromHtml("#16233F");
        public static readonly Color NavText = ColorTranslator.FromHtml("#A9B7D0");
        public static readonly Color NavyHover = ColorTranslator.FromHtml("#1E3052");
        public static readonly Color Teal = ColorTranslator.FromHtml("#14B8A6");
        public static readonly Color TealDark = ColorTranslator.FromHtml("#0D9488");
        public static readonly Color TealSoft = ColorTranslator.FromHtml("#CCFBF1");
        public static readonly Color Amber = ColorTranslator.FromHtml("#F59E0B");
        public static readonly Color AmberSoft = ColorTranslator.FromHtml("#FEF3C7");
        public static readonly Color Red = ColorTranslator.FromHtml("#EF4444");
        public static readonly Color RedDark = ColorTranslator.FromHtml("#DC2626");
        public static readonly Color RedSoft = ColorTranslator.FromHtml("#FEE2E2");
        public static readonly Color Green = ColorTranslator.FromHtml("#22C55E");
        public static readonly Color GreenDark = ColorTranslator.FromHtml("#16A34A");
        public static readonly Color GreenSoft = ColorTranslator.FromHtml("#DCFCE7");
        public static readonly Color Blue = ColorTranslator.FromHtml("#3B82F6");
        public static readonly Color BlueSoft = ColorTranslator.FromHtml("#DBEAFE");
        public static readonly Color Violet = ColorTranslator.FromHtml("#8B5CF6");
        public static readonly Color VioletSoft = ColorTranslator.FromHtml("#EDE9FE");
        public static readonly Color Bg = ColorTranslator.FromHtml("#F3F5F9");
        public static readonly Color Border = ColorTranslator.FromHtml("#E2E8F0");
        public static readonly Color FieldBorder = ColorTranslator.FromHtml("#CBD5E1");
        public static readonly Color Text = ColorTranslator.FromHtml("#0F172A");
        public static readonly Color Muted = ColorTranslator.FromHtml("#64748B");
        public static readonly Color Soft = ColorTranslator.FromHtml("#F1F5F9");

        public static Font F(float size, FontStyle style)
        {
            return new Font("Segoe UI", size, style);
        }

        public static Font F(float size)
        {
            return new Font("Segoe UI", size, FontStyle.Regular);
        }

        public static GraphicsPath RoundRect(RectangleF r, float radius)
        {
            var p = new GraphicsPath();
            if (radius <= 0.5f || r.Width < 4f || r.Height < 4f)
            {
                p.AddRectangle(r);
                return p;
            }
            float d = radius * 2f;
            if (d > r.Width) d = r.Width;
            if (d > r.Height) d = r.Height;
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        public static Color Mix(Color a, Color b, float t)
        {
            int r = (int)(a.R + (b.R - a.R) * t);
            int g = (int)(a.G + (b.G - a.G) * t);
            int bl = (int)(a.B + (b.B - a.B) * t);
            return Color.FromArgb(r, g, bl);
        }

        public static void DrawText(Graphics g, string text, Font font, Color color, RectangleF rect,
            StringAlignment horizontal, StringAlignment vertical)
        {
            if (string.IsNullOrEmpty(text)) return;
            using (var br = new SolidBrush(color))
            using (var sf = new StringFormat())
            {
                sf.Alignment = horizontal;
                sf.LineAlignment = vertical;
                sf.Trimming = StringTrimming.EllipsisCharacter;
                sf.FormatFlags = StringFormatFlags.NoWrap;
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                g.DrawString(text, font, br, rect, sf);
            }
        }
    }
}
