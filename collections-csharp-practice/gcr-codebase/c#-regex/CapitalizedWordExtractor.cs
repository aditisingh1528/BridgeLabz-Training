using System;
using System.Text.RegularExpressions;

class CapitalizedWordExtractor
{
    static void Main(string[] args)
    {
        //ask user for sentence
        Console.WriteLine("Enter sentence:");
        string text = Console.ReadLine();

        string pattern = @"\b[A-Z][a-z]*\b";
        foreach (Match m in Regex.Matches(text, pattern))
        {
            Console.WriteLine(m.Value);
        }
    }
}
