using System;
using System.Text.RegularExpressions;

class ProgrammingLanguageExtractor
{
    static void Main(string[] args)
    {
        //ask user for text
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        string pattern = @"\b(JavaScript|Java|Python|Go)\b";
        foreach (Match m in Regex.Matches(text, pattern))
        {
            Console.WriteLine(m.Value);
        }
    }
}
