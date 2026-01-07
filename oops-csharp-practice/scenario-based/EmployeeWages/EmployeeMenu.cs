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
            // UC1
            employeeService.CheckAttendance();
        }
    }
}
