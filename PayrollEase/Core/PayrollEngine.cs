using System;
using System.Collections.Generic;
using System.Data;

namespace PayrollEase
{
    /// <summary>One employee's computed payroll for a period (also used for saved payslips).</summary>
    public class PayLine
    {
        public int EmployeeId;
        public string EmployeeNo = "";
        public string Name = "";
        public string Position = "";
        public string Department = "";
        public string PayType = "";
        public decimal Rate;
        public decimal DailyRate;
        public decimal HourlyRate;
        public decimal DaysPaid;
        public decimal HoursWorked;
        public decimal OvertimeHours;
        public int LateMinutes;
        public int UndertimeMinutes;
        public int Incomplete;
        public decimal BasicPay;
        public decimal OvertimePay;
        public decimal Allowance;
        public decimal OtherEarnings;
        public decimal GrossPay;
        public decimal LateDeduction;
        public decimal SSS;
        public decimal PhilHealth;
        public decimal PagIbig;
        public decimal Tax;
        public decimal OtherDeductions;
        public decimal TotalDeductions;
        public decimal NetPay;
    }

    /// <summary>Philippine TRAIN-law monthly withholding tax table (in force since 2023).</summary>
    public static class TaxTable
    {
        public static decimal Monthly(decimal taxable)
        {
            if (taxable <= 20833m) return 0m;
            if (taxable < 33333m) return (taxable - 20833m) * 0.15m;
            if (taxable < 66667m) return 1875m + (taxable - 33333m) * 0.20m;
            if (taxable < 166667m) return 8541.80m + (taxable - 66667m) * 0.25m;
            if (taxable < 666667m) return 33541.80m + (taxable - 166667m) * 0.30m;
            return 183541.80m + (taxable - 666667m) * 0.35m;
        }
    }

    public static class PayrollEngine
    {
        private const string InsertPayslipSql =
            "INSERT INTO Payslips (PeriodId, EmployeeId, DaysPaid, HoursWorked, OvertimeHours, LateMinutes, UndertimeMinutes, DailyRate, HourlyRate, " +
            "BasicPay, OvertimePay, Allowance, OtherEarnings, GrossPay, LateDeduction, SSS, PhilHealth, PagIbig, Tax, OtherDeductions, TotalDeductions, NetPay) " +
            "VALUES ((SELECT Id FROM PayrollPeriods WHERE PeriodStart = @s AND PeriodEnd = @e), @EmployeeId, @DaysPaid, @HoursWorked, @OvertimeHours, @LateMinutes, @UndertimeMinutes, " +
            "@DailyRate, @HourlyRate, @BasicPay, @OvertimePay, @Allowance, @OtherEarnings, @GrossPay, @LateDeduction, @SSS, @PhilHealth, @PagIbig, @Tax, @OtherDeductions, @TotalDeductions, @NetPay)";

        private static decimal Clamp(decimal v, decimal lo, decimal hi)
        {
            if (hi < lo) hi = lo;
            if (v < lo) return lo;
            if (v > hi) return hi;
            return v;
        }

        /// <summary>Computes payroll for every active employee for the given inclusive date range.</summary>
        public static List<PayLine> Compute(DateTime start, DateTime end)
        {
            Database db = new Database();
            DateTime s = start.Date;
            DateTime e = end.Date;

            DataTable emps = db.select("SELECT * FROM Employees WHERE IsActive = 1 ORDER BY LastName, FirstName");

            DataTable att = db.select(
                "SELECT EmployeeId, " +
                "SUM(CASE WHEN Status IN (N'Present', N'Late', N'Leave') THEN 1.0 WHEN Status = N'Half Day' THEN 0.5 ELSE 0.0 END) AS DaysPaid, " +
                "SUM(HoursWorked) AS HoursSum, SUM(OvertimeHours) AS OTSum, SUM(LateMinutes) AS LateMin, SUM(UndertimeMinutes) AS UnderMin, " +
                "SUM(CASE WHEN TimeIn IS NOT NULL AND TimeOut IS NULL THEN 1 ELSE 0 END) AS Incomplete " +
                "FROM Attendance WHERE WorkDate BETWEEN @s AND @e GROUP BY EmployeeId",
                new { s = s, e = e });
            var attMap = new Dictionary<int, DataRow>();
            foreach (DataRow r in att.Rows) attMap[Fmt.I(r["EmployeeId"])] = r;

            DataTable adj = db.select(
                "SELECT EmployeeId, " +
                "SUM(CASE WHEN AdjType = N'Earning' THEN Amount ELSE 0 END) AS Earn, " +
                "SUM(CASE WHEN AdjType = N'Deduction' THEN Amount ELSE 0 END) AS Ded " +
                "FROM Adjustments WHERE AdjDate BETWEEN @s AND @e GROUP BY EmployeeId",
                new { s = s, e = e });
            var adjMap = new Dictionary<int, DataRow>();
            foreach (DataRow r in adj.Rows) adjMap[Fmt.I(r["EmployeeId"])] = r;

            decimal hoursPerDay = Math.Max(1m, AppSettings.GetDecimal("HoursPerDay"));
            decimal daysPerYear = AppSettings.GetInt("WorkDaysPerWeek") == 5 ? 261m : 313m;
            int periods = AppSettings.GetInt("PayPeriodsPerMonth") == 1 ? 1 : 2;
            decimal otMult = AppSettings.GetDecimal("OvertimeMultiplier");
            bool deductLate = AppSettings.GetBool("DeductLate");

            var list = new List<PayLine>();
            foreach (DataRow emp in emps.Rows)
            {
                var l = new PayLine();
                l.EmployeeId = Fmt.I(emp["Id"]);
                l.EmployeeNo = Fmt.S(emp["EmployeeNo"]);
                l.Name = Fmt.S(emp["LastName"]) + ", " + Fmt.S(emp["FirstName"]);
                l.Position = Fmt.S(emp["Position"]);
                l.Department = Fmt.S(emp["Department"]);
                l.PayType = Fmt.S(emp["PayType"]);
                l.Rate = Fmt.D(emp["Rate"]);

                decimal daily, hourly, monthly;
                if (l.PayType == "Hourly")
                {
                    hourly = l.Rate;
                    daily = hourly * hoursPerDay;
                    monthly = daily * daysPerYear / 12m;
                }
                else if (l.PayType == "Daily")
                {
                    daily = l.Rate;
                    hourly = daily / hoursPerDay;
                    monthly = daily * daysPerYear / 12m;
                }
                else
                {
                    monthly = l.Rate;
                    daily = monthly * 12m / daysPerYear;
                    hourly = daily / hoursPerDay;
                }
                l.DailyRate = Fmt.R2(daily);
                l.HourlyRate = Math.Round(hourly, 4, MidpointRounding.AwayFromZero);

                DataRow a;
                if (attMap.TryGetValue(l.EmployeeId, out a))
                {
                    l.DaysPaid = Fmt.D(a["DaysPaid"]);
                    l.HoursWorked = Fmt.D(a["HoursSum"]);
                    l.OvertimeHours = Fmt.D(a["OTSum"]);
                    l.LateMinutes = Fmt.I(a["LateMin"]);
                    l.UndertimeMinutes = Fmt.I(a["UnderMin"]);
                    l.Incomplete = Fmt.I(a["Incomplete"]);
                }

                DataRow ad;
                if (adjMap.TryGetValue(l.EmployeeId, out ad))
                {
                    l.OtherEarnings = Fmt.D(ad["Earn"]);
                    l.OtherDeductions = Fmt.D(ad["Ded"]);
                }

                bool worked = l.DaysPaid > 0m || l.HoursWorked > 0m;

                if (l.PayType == "Hourly")
                    l.BasicPay = Fmt.R2(hourly * Math.Max(0m, l.HoursWorked - l.OvertimeHours));
                else
                    l.BasicPay = Fmt.R2(daily * l.DaysPaid);

                if (deductLate && l.PayType != "Hourly")
                    l.LateDeduction = Fmt.R2((l.LateMinutes + l.UndertimeMinutes) / 60m * hourly);

                l.OvertimePay = Fmt.R2(l.OvertimeHours * hourly * otMult);
                l.Allowance = worked ? Fmt.R2(Fmt.D(emp["Allowance"])) : 0m;
                l.GrossPay = l.BasicPay + l.OvertimePay + l.Allowance + l.OtherEarnings;

                if (worked && monthly > 0m)
                {
                    decimal sssMonthly = 0m, phMonthly = 0m, hdmfMonthly = 0m;

                    if (AppSettings.GetBool("ApplySSS"))
                    {
                        decimal msc = Math.Round(monthly / 500m, MidpointRounding.AwayFromZero) * 500m;
                        msc = Clamp(msc, AppSettings.GetDecimal("SSSMinMSC"), AppSettings.GetDecimal("SSSMaxMSC"));
                        sssMonthly = msc * AppSettings.GetDecimal("SSSRate");
                    }
                    if (AppSettings.GetBool("ApplyPhilHealth"))
                    {
                        decimal phBase = Clamp(monthly, AppSettings.GetDecimal("PhilHealthFloor"), AppSettings.GetDecimal("PhilHealthCeiling"));
                        phMonthly = phBase * AppSettings.GetDecimal("PhilHealthRate");
                    }
                    if (AppSettings.GetBool("ApplyPagIbig"))
                    {
                        decimal hdBase = Math.Min(monthly, AppSettings.GetDecimal("PagIbigMaxBase"));
                        hdmfMonthly = hdBase * AppSettings.GetDecimal("PagIbigRate");
                    }

                    l.SSS = Fmt.R2(sssMonthly / periods);
                    l.PhilHealth = Fmt.R2(phMonthly / periods);
                    l.PagIbig = Fmt.R2(hdmfMonthly / periods);

                    if (AppSettings.GetBool("ApplyTax"))
                    {
                        decimal periodTaxable = l.BasicPay - l.LateDeduction + l.OvertimePay + l.OtherEarnings
                                                - l.SSS - l.PhilHealth - l.PagIbig;
                        if (periodTaxable > 0m)
                            l.Tax = Fmt.R2(TaxTable.Monthly(periodTaxable * periods) / periods);
                    }
                }

                l.TotalDeductions = l.LateDeduction + l.SSS + l.PhilHealth + l.PagIbig + l.Tax + l.OtherDeductions;
                l.NetPay = l.GrossPay - l.TotalDeductions;
                list.Add(l);
            }
            return list;
        }

        /// <summary>Saves a payroll period and all payslips in a single database transaction.</summary>
        public static bool SavePeriod(DateTime start, DateTime end, DateTime payDate, IList<PayLine> lines, string createdBy)
        {
            var items = new List<SqlBatchItem>();
            items.Add(new SqlBatchItem(
                "INSERT INTO PayrollPeriods (PeriodStart, PeriodEnd, PayDate, Status, CreatedBy) VALUES (@s, @e, @p, N'Finalized', @createdBy)",
                new { s = start.Date, e = end.Date, p = payDate.Date, createdBy = createdBy ?? "" }));

            foreach (PayLine l in lines)
            {
                items.Add(new SqlBatchItem(InsertPayslipSql, new
                {
                    s = start.Date,
                    e = end.Date,
                    EmployeeId = l.EmployeeId,
                    DaysPaid = l.DaysPaid,
                    HoursWorked = l.HoursWorked,
                    OvertimeHours = l.OvertimeHours,
                    LateMinutes = l.LateMinutes,
                    UndertimeMinutes = l.UndertimeMinutes,
                    DailyRate = l.DailyRate,
                    HourlyRate = l.HourlyRate,
                    BasicPay = l.BasicPay,
                    OvertimePay = l.OvertimePay,
                    Allowance = l.Allowance,
                    OtherEarnings = l.OtherEarnings,
                    GrossPay = l.GrossPay,
                    LateDeduction = l.LateDeduction,
                    SSS = l.SSS,
                    PhilHealth = l.PhilHealth,
                    PagIbig = l.PagIbig,
                    Tax = l.Tax,
                    OtherDeductions = l.OtherDeductions,
                    TotalDeductions = l.TotalDeductions,
                    NetPay = l.NetPay
                }));
            }
            return new Database().Transaction(items);
        }

        public static int FindPeriodId(DateTime start, DateTime end)
        {
            object o = new Database().Scalar("SELECT Id FROM PayrollPeriods WHERE PeriodStart = @s AND PeriodEnd = @e",
                new { s = start.Date, e = end.Date });
            return Fmt.I(o);
        }

        /// <summary>Loads the saved payslips of a period as PayLine objects.</summary>
        public static List<PayLine> LoadSaved(int periodId)
        {
            DataTable dt = new Database().select(
                "SELECT p.*, e.EmployeeNo, e.LastName + N', ' + e.FirstName AS FullName, e.Position AS EmpPosition, e.Department AS EmpDepartment, " +
                "e.PayType AS EmpPayType, e.Rate AS EmpRate " +
                "FROM Payslips p INNER JOIN Employees e ON e.Id = p.EmployeeId WHERE p.PeriodId = @pid ORDER BY e.LastName, e.FirstName",
                new { pid = periodId });
            var list = new List<PayLine>();
            foreach (DataRow r in dt.Rows)
            {
                var l = new PayLine();
                l.EmployeeId = Fmt.I(r["EmployeeId"]);
                l.EmployeeNo = Fmt.S(r["EmployeeNo"]);
                l.Name = Fmt.S(r["FullName"]);
                l.Position = Fmt.S(r["EmpPosition"]);
                l.Department = Fmt.S(r["EmpDepartment"]);
                l.PayType = Fmt.S(r["EmpPayType"]);
                l.Rate = Fmt.D(r["EmpRate"]);
                l.DailyRate = Fmt.D(r["DailyRate"]);
                l.HourlyRate = Fmt.D(r["HourlyRate"]);
                l.DaysPaid = Fmt.D(r["DaysPaid"]);
                l.HoursWorked = Fmt.D(r["HoursWorked"]);
                l.OvertimeHours = Fmt.D(r["OvertimeHours"]);
                l.LateMinutes = Fmt.I(r["LateMinutes"]);
                l.UndertimeMinutes = Fmt.I(r["UndertimeMinutes"]);
                l.BasicPay = Fmt.D(r["BasicPay"]);
                l.OvertimePay = Fmt.D(r["OvertimePay"]);
                l.Allowance = Fmt.D(r["Allowance"]);
                l.OtherEarnings = Fmt.D(r["OtherEarnings"]);
                l.GrossPay = Fmt.D(r["GrossPay"]);
                l.LateDeduction = Fmt.D(r["LateDeduction"]);
                l.SSS = Fmt.D(r["SSS"]);
                l.PhilHealth = Fmt.D(r["PhilHealth"]);
                l.PagIbig = Fmt.D(r["PagIbig"]);
                l.Tax = Fmt.D(r["Tax"]);
                l.OtherDeductions = Fmt.D(r["OtherDeductions"]);
                l.TotalDeductions = Fmt.D(r["TotalDeductions"]);
                l.NetPay = Fmt.D(r["NetPay"]);
                list.Add(l);
            }
            return list;
        }
    }
}
