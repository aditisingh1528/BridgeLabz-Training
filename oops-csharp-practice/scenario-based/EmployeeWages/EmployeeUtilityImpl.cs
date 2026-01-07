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
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
