using System;
using System.Text.RegularExpressions;

class CreditCardValidator
{
    static void Main(string[] args)
    {
        //ask user for card number
        Console.WriteLine("Enter card number:");
        string card = Console.ReadLine();

        string pattern = @"^(4\d{15}|5\d{15})$";
        Console.WriteLine(Regex.IsMatch(card, pattern) ? "Valid" : "Invalid");
    }
}
