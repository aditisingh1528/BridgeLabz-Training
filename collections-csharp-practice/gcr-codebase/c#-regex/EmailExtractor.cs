using System;
using System.Text.RegularExpressions;

class EmailExtractor
{
    static void Main(string[] args)
    {
        //ask user for text
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        string pattern = @"[\w.-]+@[\w.-]+\.\w+";
        foreach (Match m in Regex.Matches(text, pattern))
        {
            Console.WriteLine(m.Value);
        }
    }
}
