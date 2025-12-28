using System;

public class LongestWord{
    static void Main(){
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');

        string longest = words[0];

        foreach (string word in words){
            if (word.Length > longest.Length)
                longest = word;
        }

        Console.WriteLine("Longest word: " + longest);
    }
}
