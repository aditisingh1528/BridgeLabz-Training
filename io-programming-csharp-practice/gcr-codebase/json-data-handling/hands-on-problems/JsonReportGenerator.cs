using System;
using Newtonsoft.Json;

class JsonReportGenerator
{
    static void Main(string[] args)
    {
        //Simulated database records
        var employeeRecords = new[]
        {
            new { EmployeeName = "Amit", Salary = 40000 },
            new { EmployeeName = "Ravi", Salary = 55000 }
        };

        //Generating JSON report
        string reportJson = JsonConvert.SerializeObject(employeeRecords, Formatting.Indented);

        Console.WriteLine("Generated JSON Report:");
        Console.WriteLine(reportJson);
    }
}
