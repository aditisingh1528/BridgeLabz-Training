using System;

class PasswordMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter password length:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter actual password:");
        string password = Console.ReadLine().ToLower();

        char[] characters = new char[26];

        for (int i = 0; i < 26; i++)
        {
            characters[i] = (char)('a' + i);
        }

        char[] current = new char[n];

        PasswordCracker cracker = new PasswordCracker(password);
        cracker.CrackPassword(characters, current, 0);
    }
}