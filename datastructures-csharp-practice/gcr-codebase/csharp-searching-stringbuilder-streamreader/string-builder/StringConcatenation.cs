using System;
using System.Text;

class StringConcatenation
{
    static string ConcatenateStrings(string[] arr)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < arr.Length; i++)
        {
            sb.Append(arr[i]);
        }
        return sb.ToString();
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of strings:");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] arr = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter string " + (i + 1) + ":");
            arr[i] = Console.ReadLine();
        }

        string result = ConcatenateStrings(arr);

        Console.WriteLine("Final concatenated string:");
        Console.WriteLine(result);
    }
}