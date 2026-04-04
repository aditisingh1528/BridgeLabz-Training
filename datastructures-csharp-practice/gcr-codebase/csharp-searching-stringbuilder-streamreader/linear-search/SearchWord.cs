using System;

class SearchWord
{
    static string FindSentence(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(word))
            {
                return sentences[i];
            }
        }

        return null;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of sentences:");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] sentences = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter sentence " + (i + 1) + ":");
            sentences[i] = Console.ReadLine();
        }

        Console.WriteLine("Enter word to search:");
        string word = Console.ReadLine();

        string result = FindSentence(sentences, word);

        if (result != null)
        {
            Console.WriteLine("First sentence containing the word:");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Word not found in any sentence");
        }
    }
}