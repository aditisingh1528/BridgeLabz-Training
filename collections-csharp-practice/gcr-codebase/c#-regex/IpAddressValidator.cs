using System;
using System.Text.RegularExpressions;

class IpAddressValidator
{
    static void Main(string[] args)
    {
        //ask user for ip address
        Console.WriteLine("Enter IP address:");
        string ip = Console.ReadLine();

        string pattern = @"^((25[0-5]|2[0-4]\d|[01]?\d\d?)\.){3}(25[0-5]|2[0-4]\d|[01]?\d\d?)$";
        Console.WriteLine(Regex.IsMatch(ip, pattern) ? "Valid" : "Invalid");
    }
}
