using System;

namespace EmployeeProject
{
    public interface IEmployee
    {
        // UC1
        void CheckAttendance();

        // UC2
        void CalculateDailyWage();
    }
}