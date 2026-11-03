using System;
using System.Globalization;

namespace PayrollEase
{
    /// <summary>Formatting and safe-conversion helpers used across the application.</summary>
    public static class Fmt
    {
        public const string Peso = "\u20B1";
        public static readonly CultureInfo Ci = CultureInfo.InvariantCulture;

        public static string Money(decimal v) { return Peso + v.ToString("N2", Ci); }
        public static string Num(decimal v) { return v.ToString("N2", Ci); }

        public static decimal D(object o)
        {
            if (o == null || o is DBNull) return 0m;
            try { return Convert.ToDecimal(o, Ci); } catch { return 0m; }
        }

        public static int I(object o)
        {
            if (o == null || o is DBNull) return 0;
            try { return Convert.ToInt32(o, Ci); } catch { return 0; }
        }

        public static string S(object o)
        {
            if (o == null || o is DBNull) return "";
            return Convert.ToString(o, Ci) ?? "";
        }

        public static bool B(object o)
        {
            if (o == null || o is DBNull) return false;
            if (o is bool) return (bool)o;
            try { return Convert.ToInt32(o, Ci) != 0; } catch { return false; }
        }

        public static DateTime? Dt(object o)
        {
            if (o == null || o is DBNull) return null;
            if (o is DateTime) return (DateTime)o;
            return null;
        }

        public static bool TryMoney(string s, out decimal v)
        {
            v = 0m;
            if (string.IsNullOrWhiteSpace(s)) return false;
            string clean = s.Replace(Peso, "").Replace(",", "").Trim();
            return decimal.TryParse(clean, NumberStyles.Number, Ci, out v);
        }

        public static decimal R2(decimal v) { return Math.Round(v, 2, MidpointRounding.AwayFromZero); }

        public static string Period(DateTime s, DateTime e)
        {
            if (s.Year == e.Year)
                return s.ToString("MMM dd", Ci) + " - " + e.ToString("MMM dd, yyyy", Ci);
            return s.ToString("MMM dd, yyyy", Ci) + " - " + e.ToString("MMM dd, yyyy", Ci);
        }

        public static string Initials(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "U";
            string[] parts = name.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpperInvariant();
            return (parts[0].Substring(0, 1) + parts[parts.Length - 1].Substring(0, 1)).ToUpperInvariant();
        }
    }
}
