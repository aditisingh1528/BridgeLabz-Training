using System;
using System.IO;
using System.Collections.Generic;


class Student
{
    public int Id;
    public string Name;
    public int Age;
    public int Marks;
}


class CSVToObjects
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        string[] lines = File.ReadAllLines("students.csv");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] d = lines[i].Split(',');

            Student s = new Student
            {
                Id = int.Parse(d[0]),
                Name = d[1],
                Age = int.Parse(d[2]),
                Marks = int.Parse(d[3])
            };

            students.Add(s);
        }

        foreach (Student s in students)
        {
            Console.WriteLine($"{s.Id} {s.Name} {s.Age} {s.Marks}");
        }
    }
}