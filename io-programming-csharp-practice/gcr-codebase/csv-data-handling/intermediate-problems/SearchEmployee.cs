using System;
using System.IO;

class SearchEmployee
{
    static void Main(string[] args)
    {
        string path = "employees.csv";
        string[] lines = File.ReadAllLines(path);

        Console.Write("Enter employee name: ");
        string searchName = Console.ReadLine();

        bool found = false;

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            if (data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Department: " + data[2]);
                Console.WriteLine("Salary: " + data[3]);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Employee not found.");
        }
    }
}