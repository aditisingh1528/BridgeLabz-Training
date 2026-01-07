using System;
using System.Collections.Generic;

// Interface
interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

// Abstract Class
abstract class Employee : IDepartment
{
    private int employeeId;
    private string name;
    protected double baseSalary;
    private string department;

    public int EmployeeId => employeeId;
    public string Name => name;

    protected Employee(int id, string name, double salary)
    {
        employeeId = id;
        this.name = name;
        baseSalary = salary;
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary()}, Dept: {department}");
    }

    public void AssignDepartment(string dept) => department = dept;
    public string GetDepartmentDetails() => department;
}

// Derived Classes
class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary) { }

    public override double CalculateSalary() => baseSalary;
}

class PartTimeEmployee : Employee
{
    private int hoursWorked;

    public PartTimeEmployee(int id, string name, double hourlyRate, int hours)
        : base(id, name, hourlyRate)
    {
        hoursWorked = hours;
    }

    public override double CalculateSalary() => baseSalary * hoursWorked;
}
