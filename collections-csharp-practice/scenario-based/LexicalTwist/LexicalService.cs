using System;
using System.Collections.Generic;
using System.Text;

namespace LexicalTwist.Service
{
    // Contains all puzzle logic
    public class LexicalService
    {
        // Check if input is a valid single word
        public bool IsValidWord(string word)
        {
            return !word.Contains(" ");
        }

        // Check if second word is reverse of first (case-insensitive)
        public bool IsReverse(string first, string second)
        {
            char[] arr = first.ToLower().ToCharArray();
            Array.Reverse(arr);
            return new string(arr).Equals(second.ToLower());
        }

        // Reverse, lowercase and replace vowels with '@'
        public string TransformReversedWord(string word)
        {
            char[] arr = word.ToLower().ToCharArray();
            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if ("aeiou".Contains(arr[i]))
                    arr[i] = '@';
            }

            return new string(arr);
        }

        // Process non-reverse case
        public string ProcessCombinedWords(string first, string second)
        {
            string combined = (first + second).ToUpper();

            List<char> vowels = new List<char>();
            List<char> consonants = new List<char>();

            foreach (char c in combined)
            {
                if ("AEIOU".Contains(c))
                    vowels.Add(c);
                else
                    consonants.Add(c);
            }

            if (vowels.Count > consonants.Count)
                return GetFirstTwoUnique(vowels);

            if (consonants.Count > vowels.Count)
                return GetFirstTwoUnique(consonants);

            return "Vowels and consonants are equal";
        }

        // Get first two unique characters
        private string GetFirstTwoUnique(List<char> list)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in list)
            {
                if (!result.ToString().Contains(c))
                {
                    result.Append(c);
                }

                if (result.Length == 2)
                    break;
            }

            return result.ToString();
        }
    }
}