using System;
using System.IO;

class WriteEmployeeCSV
{
    static void Main(string[] args)
    {
        string path = "employees.csv";

        string[] employees =
        {
            "ID,Name,Department,Salary",
            "1,Krishna,HR,40000",
            "2,Priya,IT,50000",
            "3,Rohan,Finance,45000",
            "4,Sneha,Marketing,35000",
            "5,Karan,IT,55000"
        };

        File.WriteAllLines(path, employees);

        Console.WriteLine("Employee CSV file created successfully.");
    }
}