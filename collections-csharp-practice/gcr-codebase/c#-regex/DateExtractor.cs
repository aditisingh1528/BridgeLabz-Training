using System;
using System.Text.RegularExpressions;

class DateExtractor
{
    static void Main(string[] args)
    {
        //ask user for text
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";
        foreach (Match m in Regex.Matches(text, pattern))
        {
            Console.WriteLine(m.Value);
        }
    }
}
