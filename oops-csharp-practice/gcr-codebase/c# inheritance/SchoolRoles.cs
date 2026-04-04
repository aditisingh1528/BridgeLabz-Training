using System;

class Person
{
    protected string Name;
    public Person(string n) { Name = n; }
}

class Teacher : Person
{
    public Teacher(string n) : base(n) { }
    public void Role() => Console.WriteLine("Teacher");
}

class Student : Person
{
    public Student(string n) : base(n) { }
    public void Role() => Console.WriteLine("Student");
}

class Program
{
    static void Main()
    {
        Teacher t = new Teacher("Anita");
        Student s = new Student("Rahul");

        t.Role();
        s.Role();
    }
}
