using System;
using System.Collections.Generic;

namespace PayrollEase
{
    /// <summary>Optional sample employees and attendance so the dashboard can be explored right away.</summary>
    public static class DemoData
    {
        private class Emp
        {
            public string First, Last, Position, Department, PayType;
            public decimal Rate, Allowance;
            public Emp(string first, string last, string position, string dept, string payType, decimal rate, decimal allowance)
            {
                First = first; Last = last; Position = position; Department = dept; PayType = payType; Rate = rate; Allowance = allowance;
            }
        }

        public static bool IsLoaded()
        {
            return Fmt.I(new Database().Scalar("SELECT COUNT(*) FROM Employees WHERE EmployeeNo LIKE N'DEMO-%'")) > 0;
        }

        public static void Load()
        {
            Database db = new Database();
            var emps = new List<Emp>
            {
                new Emp("Maria", "Santos", "Cashier", "Sales", "Daily", 610m, 500m),
                new Emp("Juan", "Dela Cruz", "Store Supervisor", "Operations", "Monthly", 24000m, 1000m),
                new Emp("Ana", "Reyes", "Bookkeeper", "Finance", "Monthly", 20000m, 500m),
                new Emp("Pedro", "Garcia", "Driver", "Operations", "Daily", 650m, 500m),
                new Emp("Liza", "Mendoza", "Sales Associate", "Sales", "Hourly", 85m, 0m),
                new Emp("Carlo", "Ramos", "Warehouse Staff", "Production", "Daily", 600m, 0m),
                new Emp("Grace", "Bautista", "Admin Assistant", "Administration", "Monthly", 18000m, 500m),
                new Emp("Mark", "Villanueva", "Production Lead", "Production", "Monthly", 27000m, 1000m)
            };

            var ids = new List<int>();
            int n = 1;
            foreach (Emp e in emps)
            {
                string no = "DEMO-" + n.ToString("D4");
                n++;
                if (Fmt.I(db.Scalar("SELECT COUNT(*) FROM Employees WHERE EmployeeNo = @n", new { n = no })) > 0) continue;
                db.Insert("Employees", new
                {
                    EmployeeNo = no,
                    FirstName = e.First,
                    MiddleName = "",
                    LastName = e.Last,
                    Position = e.Position,
                    Department = e.Department,
                    ContactNumber = "0917 000 " + (1000 + n).ToString(),
                    Email = e.First.ToLowerInvariant() + "@example.com",
                    Address = "Calapan City, Oriental Mindoro",
                    DateHired = DateTime.Today.AddMonths(-8 - n),
                    PayType = e.PayType,
                    Rate = e.Rate,
                    Allowance = e.Allowance,
                    SSSNo = "",
                    PhilHealthNo = "",
                    PagIbigNo = "",
                    TIN = "",
                    IsActive = true
                });
                ids.Add(Fmt.I(db.Scalar("SELECT Id FROM Employees WHERE EmployeeNo = @n", new { n = no })));
            }

            var rnd = new Random(2026);
            TimeSpan start = AppSettings.GetTime("WorkStart");
            TimeSpan end = AppSettings.GetTime("WorkEnd");
            bool fiveDay = AppSettings.GetInt("WorkDaysPerWeek") == 5;

            foreach (int empId in ids)
            {
                for (int back = 20; back >= 1; back--)
                {
                    DateTime day = DateTime.Today.AddDays(-back);
                    if (day.DayOfWeek == DayOfWeek.Sunday) continue;
                    if (fiveDay && day.DayOfWeek == DayOfWeek.Saturday) continue;

                    int roll = rnd.Next(100);
                    AttendanceResult r;
                    DateTime? tin = null;
                    DateTime? tout = null;
                    if (roll < 5)
                    {
                        r = AttendanceCalc.Compute(day, null, null, "Absent");
                    }
                    else if (roll < 8)
                    {
                        r = AttendanceCalc.Compute(day, null, null, "Leave");
                    }
                    else
                    {
                        tin = day.Date + start + TimeSpan.FromMinutes(rnd.Next(-15, 36));
                        int outOffset = rnd.Next(100) < 25 ? rnd.Next(35, 120) : rnd.Next(-12, 20);
                        tout = day.Date + end + TimeSpan.FromMinutes(outOffset);
                        r = AttendanceCalc.Compute(day, tin, tout, null);
                    }

                    db.Insert("Attendance", new
                    {
                        EmployeeId = empId,
                        WorkDate = day.Date,
                        TimeIn = tin,
                        TimeOut = tout,
                        HoursWorked = r.Hours,
                        LateMinutes = r.Late,
                        UndertimeMinutes = r.Under,
                        OvertimeHours = r.Overtime,
                        Status = r.Status,
                        Remarks = "Sample data"
                    });
                }
            }
        }

        public static bool Remove()
        {
            string ids = "SELECT Id FROM Employees WHERE EmployeeNo LIKE N'DEMO-%'";
            var items = new List<SqlBatchItem>();
            items.Add(new SqlBatchItem("DELETE FROM Payslips WHERE EmployeeId IN (" + ids + ")", null));
            items.Add(new SqlBatchItem("DELETE FROM Attendance WHERE EmployeeId IN (" + ids + ")", null));
            items.Add(new SqlBatchItem("DELETE FROM Adjustments WHERE EmployeeId IN (" + ids + ")", null));
            items.Add(new SqlBatchItem("DELETE FROM Employees WHERE EmployeeNo LIKE N'DEMO-%'", null));
            items.Add(new SqlBatchItem("DELETE FROM PayrollPeriods WHERE NOT EXISTS (SELECT 1 FROM Payslips WHERE PeriodId = PayrollPeriods.Id)", null));
            return new Database().Transaction(items);
        }
    }
}
