using System;
using FlipKey.Service;

namespace FlipKey.Menu
{
    // Handles user input/output
    public class FlipKeyMenu
    {
        private FlipKeyService service = new FlipKeyService();

        public void ShowMenu()
        {
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();

            string result = service.CleanseAndInvert(input);

            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
                Console.WriteLine($"The generated key is - {result}");
            }
        }
    }
}