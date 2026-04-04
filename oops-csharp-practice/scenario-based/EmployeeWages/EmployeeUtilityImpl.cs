using System;

namespace EmployeeProject
{
    public class EmployeeUtilityImpl : IEmployee
    {
        Random random = new Random();

        // UC1
        public void CheckAttendance()
        {
            int isPresent = random.Next(0, 2);
            Console.WriteLine(isPresent == 1 ? "Employee is Present" : "Employee is Absent");
        }

        // UC2, UC3, UC4
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

            Console.WriteLine("Daily Employee Wage: " +
                (empHours * Employee.EMP_RATE_PER_HOUR));
        }

        // UC5
        public void CalculateMonthlyWage()
        {
            int totalWage = 0;

            for (int day = 1; day <= Employee.MAX_WORKING_DAYS; day++)
            {
                int empType = random.Next(1, 3);
                int empHours = empType == Employee.IS_FULL_TIME
                    ? Employee.FULL_DAY_HOUR
                    : Employee.PART_TIME_HOUR;

                totalWage += empHours * Employee.EMP_RATE_PER_HOUR;
            }

            Console.WriteLine("Monthly Wage (20 days): " + totalWage);
        }

        // UC6: Wage till max days OR max hours
        public void CalculateWageTillCondition()
        {
            int totalDays = 0;
            int totalHours = 0;
            int totalWage = 0;

            while (totalDays < Employee.MAX_WORKING_DAYS &&
                   totalHours < Employee.MAX_WORKING_HOURS)
            {
                int empType = random.Next(1, 3);
                int empHours = empType == Employee.IS_FULL_TIME
                    ? Employee.FULL_DAY_HOUR
                    : Employee.PART_TIME_HOUR;

                totalDays++;
                totalHours += empHours;
                totalWage += empHours * Employee.EMP_RATE_PER_HOUR;
            }

            Console.WriteLine("Total Working Days: " + totalDays);
            Console.WriteLine("Total Working Hours: " + totalHours);
            Console.WriteLine("Total Wage: " + totalWage);
        }
    }
}