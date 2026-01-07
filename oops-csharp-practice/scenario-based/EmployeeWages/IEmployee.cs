using System;

namespace EmployeeProject
{
    public interface IEmployee
    {
        void CheckAttendance();        // UC1
        void CalculateDailyWage();     // UC2, UC3, UC4
        void CalculateMonthlyWage();   // UC5
        void CalculateWageTillCondition(); // UC6
    }
}
