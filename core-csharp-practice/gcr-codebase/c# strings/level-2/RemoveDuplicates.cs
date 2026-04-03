using System;

public class RemoveDuplicates{
    static void Main(){
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        string result = "";

        foreach (char ch in text){
            if (!result.Contains(ch))
                result += ch;
        }

        Console.WriteLine("After removing duplicates: " + result);
    }
}
