using System;

public class PalindromeCheck{
    static void Main(){
		//taking input
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        string reverse = "";
		
        for (int i = text.Length - 1; i >= 0; i--)
            reverse += text[i];
		//output
        if (text.Equals(reverse))
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a Palindrome");
    }
}
