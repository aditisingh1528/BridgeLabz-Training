using System;
using System.IO;


class ReadStudentCSV
{
    static void Main(string[] args)
    {
        string path = "students.csv";

        string[] lines = File.ReadAllLines(path);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            Console.WriteLine("ID: " + data[0] +" | Name: " + data[1] +" | Age: " + data[2] +" | Marks: " + data[3]);
        }
    }
}