using System;

class EmployeeManagementSystem
{
    public static string CompanyName = "TechCorp";
    private static int totalEmployees = 0;

    public readonly int Id;
    public string Name;
    public string Designation;

    public EmployeeManagementSystem(string name, int id, string designation)
    {
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        totalEmployees++;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    public void Display(object obj)
    {
        if (obj is EmployeeManagementSystem)
        {
            Console.WriteLine(Name + " - " + Designation);
        }
    }
}

class Program
{
    static void Main()
    {
        EmployeeManagementSystem emp =
            new EmployeeManagementSystem("Aditi", 101, "Developer");

        emp.Display(emp);
        EmployeeManagementSystem.DisplayTotalEmployees();
    }
}
