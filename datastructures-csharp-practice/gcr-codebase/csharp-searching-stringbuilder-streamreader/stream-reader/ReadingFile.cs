using System;
using System.IO;

class ReadingsFile
{
    static void ReadFile(string filePath)
    {
        StreamReader reader = new StreamReader(filePath);

        string line;

        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter file path:");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            ReadFile(filePath);
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}