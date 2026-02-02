using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class CsvToJsonConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter CSV file path:");
        string csvFilePath = Console.ReadLine();

        string[] csvLines = File.ReadAllLines(csvFilePath);
        List<Dictionary<string, string>> jsonRecords = new List<Dictionary<string, string>>();

        string[] columnHeaders = csvLines[0].Split(',');

        //Processing CSV rows
        for (int i = 1; i < csvLines.Length; i++)
        {
            string[] rowValues = csvLines[i].Split(',');
            Dictionary<string, string> record = new Dictionary<string, string>();

            for (int j = 0; j < columnHeaders.Length; j++)
            {
                record[columnHeaders[j]] = rowValues[j];
            }

            jsonRecords.Add(record);
        }

        string jsonOutput = JsonConvert.SerializeObject(jsonRecords, Formatting.Indented);
        Console.WriteLine(jsonOutput);
    }
}
