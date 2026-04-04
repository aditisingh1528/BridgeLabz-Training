using Newtonsoft.Json;
using System;

class Student
{
    static void Main(string[] args)
    {
        var student = new
        {
            name = "Aniket",
            age = 22,
            subjects = new string[] { "Math", "Physics", "CS" }
        };

        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine(json);
    }
}
