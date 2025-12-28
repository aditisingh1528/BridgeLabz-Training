using System;

public class SubstringCount{
    static void Main(){
        Console.Write("Enter main string: ");
        string text = Console.ReadLine();

        Console.Write("Enter substring: ");
        string sub = Console.ReadLine();

        int count = 0;

        for (int i = 0; i <= text.Length - sub.Length; i++){
            if (text.Substring(i, sub.Length) == sub)
                count++;
        }

        Console.WriteLine("Occurrences: " + count);
    }
}
