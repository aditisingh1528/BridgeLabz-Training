using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public int Age;
    public int Marks;
}

class JsonCsvConverter
{
    static void Main(string[] args)
    {
        ConvertJsonToCsv("students.json", "students.csv");
        ConvertCsvToJson("students.csv", "students_output.json");

        Console.WriteLine("JSON ↔ CSV conversion completed.");
    }

    static void ConvertJsonToCsv(string jsonPath, string csvPath)
    {
        string json = File.ReadAllText(jsonPath);
        List<Student> students = JsonSerializer.Deserialize<List<Student>>(json);

        using (StreamWriter sw = new StreamWriter(csvPath)){
            sw.WriteLine("Id,Name,Age,Marks");

            foreach (Student s in students){
                sw.WriteLine($"{s.Id},{s.Name},{s.Age},{s.Marks}");
            
			}
        
		}
    
	}

    static void ConvertCsvToJson(string csvPath, string jsonPath)
    {
        string[] lines = File.ReadAllLines(csvPath);
        List<Student> students = new List<Student>();

        for (int i = 1; i < lines.Length; i++){
            string[] d = lines[i].Split(',');

            students.Add(new Student{
                Id = int.Parse(d[0]),
                Name = d[1],
                Age = int.Parse(d[2]),
                Marks = int.Parse(d[3])
            });
        }

        string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(jsonPath, json);
    }
}