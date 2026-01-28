using System;
using System.Text.RegularExpressions;

class HexColorValidator
{
    static void Main(string[] args)
    {
        //ask user for hex color
        Console.WriteLine("Enter hex color code:");
        string color = Console.ReadLine();

        string pattern = @"^#[0-9A-Fa-f]{6}$";
        Console.WriteLine(Regex.IsMatch(color, pattern) ? "Valid" : "Invalid");
    }
}
