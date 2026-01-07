using System;

namespace EmployeeProject
{
    public class EmployeeMenu
    {
        IEmployee employeeService;

        public EmployeeMenu()
        {
            employeeService = new EmployeeUtilityImpl();
        }

        public void Start()
        {
            employeeService.CheckAttendance();            // UC1
            employeeService.CalculateDailyWage();         // UC2–UC4
            employeeService.CalculateMonthlyWage();       // UC5
            employeeService.CalculateWageTillCondition(); // UC6
        }
    }
}