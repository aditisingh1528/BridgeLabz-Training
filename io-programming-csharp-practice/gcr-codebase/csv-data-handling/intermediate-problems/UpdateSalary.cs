using System;
using System.IO;


class UpdateSalary
{
	
    static void Main(string[] args)
    {
        string inputPath = "employees.csv";
        string outputPath = "updated_employees.csv";

        string[] lines = File.ReadAllLines(inputPath);

        string[] updatedData = new string[lines.Length];
        updatedData[0] = lines[0];

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            if (data[2] == "IT")
            {
                double salary = double.Parse(data[3]);
                salary = salary + (salary * 0.10);
                data[3] = salary.ToString();
            }

            updatedData[i] = string.Join(",", data);
        }


        File.WriteAllLines(outputPath, updatedData);
        Console.WriteLine("Updated CSV file created.");
    }
}