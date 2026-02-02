using System;
using LexicalTwist.Service;

namespace LexicalTwist.Menu
{
    // Handles user interaction
    public class LexicalMenu
    {
        private LexicalService service = new LexicalService();

        public void ShowMenu()
        {
            Console.WriteLine("Enter the first word");
            string firstWord = Console.ReadLine();

            // Validation for first word
            if (!service.IsValidWord(firstWord))
            {
                Console.WriteLine($"{firstWord} is an invalid word");
                return;
            }

            Console.WriteLine("Enter the second word");
            string secondWord = Console.ReadLine();

            // Validation for second word
            if (!service.IsValidWord(secondWord))
            {
                Console.WriteLine($"{secondWord} is an invalid word");
                return;
            }

            // Check reverse condition
            if (service.IsReverse(firstWord, secondWord))
            {
                string output =
                    service.TransformReversedWord(firstWord);
                Console.WriteLine(output);
            }
            else
            {
                string output =
                    service.ProcessCombinedWords(firstWord, secondWord);
                Console.WriteLine(output);
            }
        }
    }
}