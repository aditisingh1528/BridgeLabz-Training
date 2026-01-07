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

            if (isPresent == 1)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }

        // UC2 & UC3: Calculate Daily Wage (Full-Time / Part-Time)
        public void CalculateDailyWage()
        {
            int empType = random.Next(1, 3); // 1 = Part-Time, 2 = Full-Time
            int empHours = 0;

            if (empType == Employee.IS_FULL_TIME)
            {
                empHours = Employee.FULL_DAY_HOUR;
                Console.WriteLine("Employee is Full-Time");
            }
            else if (empType == Employee.IS_PART_TIME)
            {
                empHours = Employee.PART_TIME_HOUR;
                Console.WriteLine("Employee is Part-Time");
            }

            int dailyWage = empHours * Employee.EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily Employee Wage: " + dailyWage);
        }
    }
}
