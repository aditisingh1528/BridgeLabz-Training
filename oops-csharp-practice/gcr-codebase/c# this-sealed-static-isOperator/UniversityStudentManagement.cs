using System;

class Student
{
    public static string UniversityName = "ABC University";
    private static int totalStudents = 0;

    public readonly int RollNumber;
    public string Name;
    public char Grade;

    public Student(string name, int rollNumber, char grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students: " + totalStudents);
    }

    public void Display(object obj)
    {
        if (obj is Student)
        {
            Console.WriteLine(Name + " - " + Grade);
        }
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Aditi", 101, 'A');
        s1.Display(s1);
        Student.DisplayTotalStudents();
    }
}