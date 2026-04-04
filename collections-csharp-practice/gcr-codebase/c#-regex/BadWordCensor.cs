using System;
using System.Text.RegularExpressions;

class BadWordCensor
{
    static void Main(string[] args)
    {
        //ask user for sentence
        Console.WriteLine("Enter sentence:");
        string text = Console.ReadLine();

        string pattern = @"damn|stupid";
        string result = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);

        Console.WriteLine(result);
    }
}
