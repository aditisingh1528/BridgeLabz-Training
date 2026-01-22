using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class WordCount
{
    static void Main(string[] args)
    {
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        try
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            StreamReader reader = new StreamReader(filePath);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(
                    new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '"' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    string key = word.ToLower();

                    if (wordCount.ContainsKey(key))
                        wordCount[key]++;
                    else
                        wordCount[key] = 1;
                }
            }

            reader.Close();

            var topWords = wordCount
                .OrderByDescending(x => x.Value)
                .Take(5);

            Console.WriteLine("Top 5 most frequent words:");
            foreach (var item in topWords)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error occurred: " + ex.Message);
        }
    }
}
