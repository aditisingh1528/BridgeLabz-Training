using System;
using System.Text.RegularExpressions;

class CurrencyExtractor
{
    static void Main(string[] args)
    {
        //ask user for text
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        string pattern = @"\$ ?\d+(\.\d{2})?";
        foreach (Match m in Regex.Matches(text, pattern))
        {
            Console.WriteLine(m.Value);
        }
    }
}
