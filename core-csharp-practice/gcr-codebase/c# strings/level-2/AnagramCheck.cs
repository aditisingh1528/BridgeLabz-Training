using System;

public class AnagramCheck{
    static void Main(){
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine().ToLower();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine().ToLower();

        if (s1.Length != s2.Length){
            Console.WriteLine("Not Anagrams");
            return;
        }

        int[] freq = new int[256];

        foreach (char ch in s1)
            freq[ch]++;

        foreach (char ch in s2)
            freq[ch]--;

        foreach (int count in freq)
        
            if (count != 0){
                Console.WriteLine("Not Anagrams");
                return;
            }
        }

        Console.WriteLine("Strings are Anagrams");
    }
}
