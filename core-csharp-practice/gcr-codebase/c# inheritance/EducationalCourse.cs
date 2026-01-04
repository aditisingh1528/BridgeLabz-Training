using System;

class Course
{
    protected string Name;
    public Course(string n) { Name = n; }
}

class OnlineCourse : Course
{
    public OnlineCourse(string n) : base(n) { }
}

class PaidOnlineCourse : OnlineCourse
{
    private double Fee;
    public PaidOnlineCourse(string n, double f) : base(n)
    {
        Fee = f;
    }

    public void Display()
    {
        Console.WriteLine($"{Name} | Fee: {Fee}");
    }
}

class Program
{
    static void Main()
    {
        PaidOnlineCourse c = new PaidOnlineCourse("C#", 2999);
        c.Display();
    }
}
