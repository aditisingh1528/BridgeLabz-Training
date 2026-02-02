using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class StudentProfile
{
    public string StudentName { get; set; }
    public int StudentAge { get; set; }
}

class ObjectListToJsonArray
{
    static void Main(string[] args)
    {
        List<StudentProfile> studentProfiles = new List<StudentProfile>();

        Console.WriteLine("Enter number of students:");
        int studentCount = int.Parse(Console.ReadLine());

        //Collecting student data
        for (int i = 0; i < studentCount; i++)
        {
            StudentProfile studentProfile = new StudentProfile();

            Console.WriteLine("Enter student name:");
            studentProfile.StudentName = Console.ReadLine();

            Console.WriteLine("Enter student age:");
            studentProfile.StudentAge = int.Parse(Console.ReadLine());

            studentProfiles.Add(studentProfile);
        }

        //Converting list to JSON array
        string jsonArrayOutput = JsonConvert.SerializeObject(studentProfiles, Formatting.Indented);

        Console.WriteLine("JSON Array:");
        Console.WriteLine(jsonArrayOutput);
    }
}
