using System;
using System.Text.RegularExpressions;

class SsnValidator
{
    static void Main(string[] args)
    {
        //ask user for ssn
        Console.WriteLine("Enter SSN:");
        string ssn = Console.ReadLine();

        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        Console.WriteLine(Regex.IsMatch(ssn, pattern) ? "Valid" : "Invalid");
    }
}
