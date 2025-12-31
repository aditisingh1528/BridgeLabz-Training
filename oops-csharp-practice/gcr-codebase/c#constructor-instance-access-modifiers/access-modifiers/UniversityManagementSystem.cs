using System;

public class Student
{
    public int rollNumber; // public
    protected string name; // protected
    private double cgpa;   // private

    public Student(int rollNumber, string name, double cgpa)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.cgpa = cgpa;
    }

    // Public getter and setter for CGPA
    public double GetCGPA()
    {
        return cgpa;
    }

    public void SetCGPA(double cgpa)
    {
        this.cgpa = cgpa;
    }
}

class PostgraduateStudent : Student
{
    public PostgraduateStudent(int rollNumber, string name, double cgpa)
        : base(rollNumber, name, cgpa) { }

    public void Display()
    {
        Console.WriteLine($"Roll No: {rollNumber}, Name: {name}, CGPA: {GetCGPA()}");
    }

    static void Main()
    {
        PostgraduateStudent pg = new PostgraduateStudent(101, "Aditi", 8.5);
        pg.Display();
    }
}