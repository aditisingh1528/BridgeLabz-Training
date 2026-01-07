using System;

namespace EmployeeProject
{
    public class EmployeeUtilityImpl : IEmployee
    {
        Random random = new Random();

        // UC1: Check Employee Attendance
        public void CheckAttendance()
        {
            int isPresent = random.Next(0, 2);
            Console.WriteLine(isPresent == 1 ? "Employee is Present" : "Employee is Absent");
        }

        // UC2, UC3, UC4: Daily Wage using SWITCH CASE
        public void CalculateDailyWage()
        {
            int empType = random.Next(1, 3);
            int empHours = 0;

            switch (empType)
            {
                case Employee.IS_FULL_TIME:
                    empHours = Employee.FULL_DAY_HOUR;
                    Console.WriteLine("Employee is Full-Time");
                    break;

                case Employee.IS_PART_TIME:
                    empHours = Employee.PART_TIME_HOUR;
                    Console.WriteLine("Employee is Part-Time");
                    break;
            }

            int dailyWage = empHours * Employee.EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily Employee Wage: " + dailyWage);
        }

        // UC5: Calculate Monthly Wage for 20 days
        public void CalculateMonthlyWage()
        {
            int totalWage = 0;

            for (int day = 1; day <= 20; day++)
            {
                int empType = random.Next(1, 3);
                int empHours = 0;

                switch (empType)
                {
                    case Employee.IS_FULL_TIME:
                        empHours = Employee.FULL_DAY_HOUR;
                        break;

                    case Employee.IS_PART_TIME:
                        empHours = Employee.PART_TIME_HOUR;
                        break;
                }

                totalWage += empHours * Employee.EMP_RATE_PER_HOUR;
            }

            Console.WriteLine("Monthly Wage (20 days): " + totalWage);
        }
    }
}