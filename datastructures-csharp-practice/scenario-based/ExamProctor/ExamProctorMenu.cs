using System;
using System.ComponentModel;

namespace ExamProctorApp
{
    public class ExamProctorMenu
    {
        private ExamUtilityImpl Exam = new ExamUtilityImpl();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Visit Question");
                Console.WriteLine("2. Save Answer");
                Console.WriteLine("3. Submit Exam");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter a choice");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Question ID: ");
                        int QID = int.Parse(Console.ReadLine());

                        Exam.VisitQuestion(QID);
                        break;

                    case 2:
                        Console.WriteLine("Enter Question ID: ");
                        int QuestionID = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Answer (1 = Correct, 0 = Incorrect): ");
                        int Answer = int.Parse(Console.ReadLine());

                        Exam.SaveAnswer(QuestionID, Answer);
                        break;

                    case 3:

                        int score = Exam.EvaluateScore();
                        Console.WriteLine("Final Score: " + score);
                        break;

                    case 4:

                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
        }
    }
}