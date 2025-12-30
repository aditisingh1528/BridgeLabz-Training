using System;

class EduQuiz
{
    static void Main()
    {
        string[] correctAnswers =
        {
            "A","B","C","D","A","C","B","D","A","B"
        };

        string[] studentAnswers = new string[10];

        Console.WriteLine("Enter answers for 10 questions (A/B/C/D):");

        for (int i = 0; i < studentAnswers.Length; i++)
        {
            while (true)
            {
                Console.Write($"Question {i + 1}: ");
                string input = Console.ReadLine().ToUpper();

                if (input == "A" || input == "B" || input == "C" || input == "D")
                {
                    studentAnswers[i] = input;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter A, B, C, or D.");
                }
            }
        }

        int score = CalculateScore(correctAnswers, studentAnswers);

        Console.WriteLine("\n--- Detailed Feedback ---");
        for (int i = 0; i < correctAnswers.Length; i++)
        {
            if (correctAnswers[i].Equals(studentAnswers[i], StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Question {i + 1}: Correct");
            else
                Console.WriteLine($"Question {i + 1}: Incorrect");
        }

        double percentage = (score / 10.0) * 100;
        Console.WriteLine($"\nScore: {score}/10");
        Console.WriteLine($"Percentage: {percentage}%");
        Console.WriteLine(percentage >= 40 ? "Result: PASS" : "Result: FAIL");
    }

    static int CalculateScore(string[] correct, string[] student)
    {
        int score = 0;
        for (int i = 0; i < correct.Length; i++)
        {
            if (correct[i].Equals(student[i], StringComparison.OrdinalIgnoreCase))
                score++;
        }
        return score;
    }
}
