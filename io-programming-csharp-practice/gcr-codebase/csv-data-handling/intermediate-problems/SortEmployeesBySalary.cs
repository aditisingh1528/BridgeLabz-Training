using System;
using System.IO;


class SortEmployeesBySalary
{
    static void Main(string[] args)
    {
        string path = "employees.csv";
        string[] lines = File.ReadAllLines(path);

        for (int i = 1; i < lines.Length - 1; i++)
        {
            for (int j = i + 1; j < lines.Length; j++)
            {
                string[] emp1 = lines[i].Split(',');
                string[] emp2 = lines[j].Split(',');

                double salary1 = double.Parse(emp1[3]);
                double salary2 = double.Parse(emp2[3]);

                if (salary1 < salary2)
                {
                    string temp = lines[i];
                    lines[i] = lines[j];
                    lines[j] = temp;
               
			   }

            }
        }


        Console.WriteLine("Top 5 Highest Paid Employees:");

        int count = Math.Min(5, lines.Length - 1);

        for (int i = 1; i <= count; i++)
        {
            string[] data = lines[i].Split(',');
            Console.WriteLine(data[1] + " | " +data[2] + " | " +data[3]);

        }

    }
}