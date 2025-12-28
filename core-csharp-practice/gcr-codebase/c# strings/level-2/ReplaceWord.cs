using System;

public class ReplaceWord{
    static void Main(){
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        string result = "";
        string[] words = sentence.Split(' ');

        foreach (string word in words){
            if (word == oldWord)
                result += newWord + " ";
            else
                result += word + " ";
        }

        Console.WriteLine("Modified Sentence: " + result.Trim());
    }
}
