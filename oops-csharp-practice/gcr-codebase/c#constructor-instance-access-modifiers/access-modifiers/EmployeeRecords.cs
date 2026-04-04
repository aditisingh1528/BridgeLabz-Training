using System;

public class Employee
{
    public int employeeID; // public
    protected string department; // protected
    private double salary; // private

    public Employee(int id, string dept, double salary)
    {
        employeeID = id;
        department = dept;
        this.salary = salary;
    }

    // Public method to modify salary
    public void SetSalary(double salary)
    {
        this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Manager : Employee
{
    public Manager(int id, string dept, double salary)
        : base(id, dept, salary) { }

    public void Display()
    {
        Console.WriteLine($"ID: {employeeID}, Dept: {department}, Salary: {GetSalary()}");
    }

    static void Main()
    {
        Manager m = new Manager(301, "IT", 75000);
        m.Display();
    }
}