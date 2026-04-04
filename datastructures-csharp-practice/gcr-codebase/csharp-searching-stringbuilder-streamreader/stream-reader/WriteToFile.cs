using System;
using System.IO;

class WriteToFile
{
    static void WriteToFile(string filePath)
    {
        StreamWriter writer = new StreamWriter(filePath);

        Console.WriteLine("Enter text (type END to stop):");

        string input;

        while (true)
        {
            input = Console.ReadLine();

            if (input == "END")
            {
                break;
            }
            writer.WriteLine(input);
		}
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter file path to write data:");
        string filePath = Console.ReadLine();

        WriteToFile(filePath);

        Console.WriteLine("Data written to file successfully");
    }
}
