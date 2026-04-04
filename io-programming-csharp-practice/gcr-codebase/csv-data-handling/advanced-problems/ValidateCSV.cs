using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCSV
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("users.csv");

        Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Regex phoneRegex = new Regex(@"^\d{10}$");

        for (int i = 1; i < lines.Length; i++){
            string[] data = lines[i].Split(',');
            bool valid = true;

            if (!emailRegex.IsMatch(data[2])){
                Console.WriteLine("Invalid Email: " + lines[i]);
                valid = false;
            }

            if (!phoneRegex.IsMatch(data[3])){
                Console.WriteLine("Invalid Phone: " + lines[i]);
                valid = false;
            }

            if (!valid)
            {
                Console.WriteLine("Row rejected\n");
         
			}

        }

    }
}