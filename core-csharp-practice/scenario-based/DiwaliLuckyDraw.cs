using System;

class FestivalLuckyDraw
{
    // Method to check winning condition
    static void CheckLuckyNumber(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Congratulations! You win a gift!!!!!");
        }
        else
        {
            Console.WriteLine("Better luck next time :(");
        }
    }

    static void Main(string[] args)
    {
        FestivalLuckyDraw draw = new FestivalLuckyDraw(); // object created (concept usage)

        Console.Write("Enter number of visitors: ");
        int visitors = int.Parse(Console.ReadLine());

        for (int i = 1; i <= visitors; i++)
        {
            Console.Write($"\nVisitor {i}, enter your number: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int number);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Skipping this visitor.");
                continue; // skip invalid input
            }

            CheckLuckyNumber(number);
        }
    }
}
