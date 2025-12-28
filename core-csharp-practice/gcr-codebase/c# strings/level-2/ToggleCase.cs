using System;

public class ToggleCase{
    static void Main(){
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        string result = "";

        foreach (char ch in text){
            if (ch >= 'a' && ch <= 'z')
                result += (char)(ch - 32);
            else if (ch >= 'A' && ch <= 'Z')
                result += (char)(ch + 32);
            else
                result += ch;
        }

        Console.WriteLine("Toggled String: " + result);
    }
}
