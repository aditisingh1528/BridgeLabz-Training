using System;
using System.Text.RegularExpressions;

class LicensePlateValidator
{
    static void Main(string[] args)
    {
        //ask user for license plate
        Console.WriteLine("Enter license plate:");
        string plate = Console.ReadLine();

        string pattern = @"^[A-Z]{2}\d{4}$";
        Console.WriteLine(Regex.IsMatch(plate, pattern) ? "Valid" : "Invalid");
    }
}
