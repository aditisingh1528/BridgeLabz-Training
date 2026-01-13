using System;
using System.Text;

class RemoveDuplicates
{
    static string RemoveDuplicateCharacters(string input)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            if (sb.ToString().IndexOf(currentChar) == -1)
            {
                sb.Append(currentChar);
            }
        }
        return sb.ToString();
    }
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string result = RemoveDuplicateCharacters(input);
        Console.WriteLine("After removing duplicates: " + result);
	}
}