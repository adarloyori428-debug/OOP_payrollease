using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace PayrollEase
{
    /// <summary>Key/value application settings stored in the Settings table (cached in memory).</summary>
    public static class AppSettings
    {
        private static readonly Dictionary<string, string> cache = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private static bool loaded;

        public static readonly Dictionary<string, string> Defaults = new Dictionary<string, string>
        {
            { "CompanyName", "My Company" },
            { "CompanyAddress", "" },
            { "CompanyContact", "" },
            { "WorkStart", "08:00" },
            { "WorkEnd", "17:00" },
            { "BreakHours", "1" },
            { "GraceMinutes", "10" },
            { "HalfDayHours", "4" },
            { "MinOvertimeMinutes", "30" },
            { "OvertimeMultiplier", "1.25" },
            { "WorkDaysPerWeek", "6" },
            { "HoursPerDay", "8" },
            { "PayPeriodsPerMonth", "2" },
            { "DeductLate", "1" },
            { "ApplySSS", "1" },
            { "ApplyPhilHealth", "1" },
            { "ApplyPagIbig", "1" },
            { "ApplyTax", "1" },
            { "SSSRate", "0.05" },
            { "SSSMinMSC", "5000" },
            { "SSSMaxMSC", "35000" },
            { "PhilHealthRate", "0.025" },
            { "PhilHealthFloor", "10000" },
            { "PhilHealthCeiling", "100000" },
            { "PagIbigRate", "0.02" },
            { "PagIbigMaxBase", "10000" }
        };

        public static void Reload()
        {
            cache.Clear();
            DataTable dt = new Database().select("SELECT SettingKey, SettingValue FROM Settings");
            foreach (DataRow r in dt.Rows)
                cache[Convert.ToString(r["SettingKey"])] = Convert.ToString(r["SettingValue"]);
            loaded = true;
        }

        public static string Get(string key)
        {
            if (!loaded) Reload();
            string v;
            if (cache.TryGetValue(key, out v)) return v;
            string d;
            return Defaults.TryGetValue(key, out d) ? d : "";
        }

        public static decimal GetDecimal(string key)
        {
            decimal v;
            if (decimal.TryParse(Get(key), NumberStyles.Number, CultureInfo.InvariantCulture, out v)) return v;
            string d;
            if (Defaults.TryGetValue(key, out d) && decimal.TryParse(d, NumberStyles.Number, CultureInfo.InvariantCulture, out v)) return v;
            return 0m;
        }

        public static int GetInt(string key)
        {
            return (int)Math.Round(GetDecimal(key));
        }

        public static bool GetBool(string key)
        {
            return Get(key) == "1";
        }

        public static TimeSpan GetTime(string key)
        {
            DateTime t;
            if (DateTime.TryParseExact(Get(key), new[] { "HH:mm", "H:mm" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out t))
                return t.TimeOfDay;
            string d;
            if (Defaults.TryGetValue(key, out d) && DateTime.TryParseExact(d, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out t))
                return t.TimeOfDay;
            return new TimeSpan(8, 0, 0);
        }

        public static void Set(string key, string value)
        {
            new Database().CUD("IF EXISTS (SELECT 1 FROM Settings WHERE SettingKey = @k) UPDATE Settings SET SettingValue = @v WHERE SettingKey = @k ELSE INSERT INTO Settings (SettingKey, SettingValue) VALUES (@k, @v)", new { k = key, v = value ?? "" });
            if (!loaded) Reload();
            cache[key] = value ?? "";
        }

        public static string Company { get { return Get("CompanyName"); } }
    }
}
