using System;
using System.Text.RegularExpressions;

class RepeatingWordFinder
{
    static void Main(string[] args)
    {
        //ask user for sentence
        Console.WriteLine("Enter sentence:");
        string text = Console.ReadLine();

        string pattern = @"\b(\w+)\s+\1\b";
        foreach (Match m in Regex.Matches(text, pattern))
        {
            Console.WriteLine(m.Groups[1].Value);
        }
    }
}
