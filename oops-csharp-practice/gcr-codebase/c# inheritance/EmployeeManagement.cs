using System;

class Employee
{
    protected string Name;
    protected int Id;
    protected double Salary;

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"{Name} | {Id} | {Salary}");
    }
}

class Manager : Employee
{
    private int TeamSize;

    public Manager(string n, int i, double s, int t) : base(n, i, s)
    {
        TeamSize = t;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"{Name} | Manager | Team Size: {TeamSize}");
    }
}

class Developer : Employee
{
    private string Language;

    public Developer(string n, int i, double s, string l) : base(n, i, s)
    {
        Language = l;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"{Name} | Developer | {Language}");
    }
}

class Intern : Employee
{
    private string Duration;

    public Intern(string n, int i, double s, string d) : base(n, i, s)
    {
        Duration = d;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"{Name} | Intern | {Duration}");
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Manager("Aditi", 101, 60000, 5);
        Employee e2 = new Developer("Rahul", 102, 50000, "C#");
        Employee e3 = new Intern("Sneha", 103, 15000, "6 Months");

        e1.DisplayDetails();
        e2.DisplayDetails();
        e3.DisplayDetails();
    }
}