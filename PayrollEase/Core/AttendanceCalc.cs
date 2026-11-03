using System;

namespace PayrollEase
{
    public class AttendanceResult
    {
        public decimal Hours;
        public int Late;
        public int Under;
        public decimal Overtime;
        public string Status = "Present";
    }

    /// <summary>Turns a time in / time out pair into hours, late, undertime, overtime and a status.</summary>
    public static class AttendanceCalc
    {
        public static readonly string[] Statuses = { "Present", "Late", "Half Day", "Absent", "Leave" };

        /// <param name="forcedStatus">"Absent" or "Leave" to force that status; otherwise null/empty for automatic.</param>
        public static AttendanceResult Compute(DateTime workDate, DateTime? timeIn, DateTime? timeOut, string forcedStatus)
        {
            var r = new AttendanceResult();

            if (forcedStatus == "Absent" || forcedStatus == "Leave")
            {
                r.Status = forcedStatus;
                return r;
            }
            if (!timeIn.HasValue)
            {
                r.Status = "Absent";
                return r;
            }

            DateTime start = workDate.Date + AppSettings.GetTime("WorkStart");
            DateTime end = workDate.Date + AppSettings.GetTime("WorkEnd");
            int grace = AppSettings.GetInt("GraceMinutes");
            decimal breakHours = AppSettings.GetDecimal("BreakHours");
            decimal halfDayHours = AppSettings.GetDecimal("HalfDayHours");
            int minOtMinutes = AppSettings.GetInt("MinOvertimeMinutes");

            DateTime tin = timeIn.Value;
            if (tin > start.AddMinutes(grace))
                r.Late = (int)Math.Floor((tin - start).TotalMinutes);

            r.Status = r.Late > 0 ? "Late" : "Present";

            if (!timeOut.HasValue)
                return r;

            DateTime tout = timeOut.Value;
            if (tout <= tin)
                return r;

            decimal span = (decimal)(tout - tin).TotalHours;
            decimal hours = span;
            if (span > 5m) hours = span - breakHours;
            if (hours < 0m) hours = 0m;
            r.Hours = Math.Round(hours, 2, MidpointRounding.AwayFromZero);

            if (tout < end)
                r.Under = (int)Math.Floor((end - tout).TotalMinutes);

            if (tout > end)
            {
                int otMinutes = (int)Math.Floor((tout - end).TotalMinutes);
                if (otMinutes >= minOtMinutes && otMinutes > 0)
                    r.Overtime = Math.Round(otMinutes / 60m, 2, MidpointRounding.AwayFromZero);
            }

            if (r.Hours < halfDayHours)
            {
                r.Status = "Half Day";
                r.Late = 0;
                r.Under = 0;
                r.Overtime = 0m;
            }
            return r;
        }
    }
}
