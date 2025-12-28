using System;

public class RemoveSpecificCharacter{
    static void Main(){
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        Console.Write("Enter character to remove: ");
        char removeChar = Console.ReadLine()[0];

        string result = "";

        foreach (char ch in text){
            if (ch != removeChar)
                result += ch;
        }

        Console.WriteLine("Modified String: " + result);
    }
}
