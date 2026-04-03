using System;

public class PalindromeChecker{
    static void Main(){
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        if (IsPalindrome(text))
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a Palindrome");
    }

    static bool IsPalindrome(string text){
        int start = 0;
        int end = text.Length - 1;

        while (start < end){
            if (text[start] != text[end])
                return false;
            start++;
            end--;
        }
        return true;
    }
}
