using System;
using System.IO;

class WordOccurrenceCounter
{
    static int CountWord(string filePath, string word)
    {
        StreamReader reader = new StreamReader(filePath);
        string line;
        int count = 0;

        while ((line = reader.ReadLine()) != null)
        {
            string[] words = line.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    count++;
                }
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter file path:");
        string filePath = Console.ReadLine();

        Console.WriteLine("Enter word to search:");
        string word = Console.ReadLine();

        if (File.Exists(filePath))
        {
            int result = CountWord(filePath, word);
            Console.WriteLine("Word occurrence count: " + result);
        }
        else
        {
            Console.WriteLine("File not found");
        }
	}
}