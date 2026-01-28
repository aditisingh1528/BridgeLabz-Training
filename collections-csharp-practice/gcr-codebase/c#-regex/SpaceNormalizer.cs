using System;
using System.Text.RegularExpressions;

class SpaceNormalizer
{
    static void Main(string[] args)
    {
        //ask user for text
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();

        string result = Regex.Replace(text, @"\s+", " ");
        Console.WriteLine(result);
    }
}
