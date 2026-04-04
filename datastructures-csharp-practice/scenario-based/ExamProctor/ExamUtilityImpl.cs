using System;

namespace ExamProctorApp
{
    public class ExamUtilityImpl : IExamTracker
    {

        private int[] QuestionStack = new int[10];
        private int Top = -1;

        private QuestionAnswer[] AnswerMap = new QuestionAnswer[10];
        private int AnswerCount = 0;

        public void VisitQuestion(int QID)
        {
            if(Top == QuestionStack.Length - 1)
            {
                Console.WriteLine("Navigation Stack full");
                return;
            }

            QuestionStack[++Top] = QID;
            Console.WriteLine("Visited Question: " + QID);
        }

        public void SaveAnswer(int QuestionID, int Answer)
        {
            for(int i = 0; i < AnswerCount; i++)
            {
                if(AnswerMap[i].GetQuestionID() == QuestionID)
                {
                    AnswerMap[i] = new QuestionAnswer(QuestionID, Answer);
                    Console.WriteLine("Answer Updated");
                    return;
                }
            }
            AnswerMap[AnswerCount++] = new QuestionAnswer(QuestionID, Answer);
            Console.WriteLine("Answer saved");
        }

        public int EvaluateScore()
        {
             int Score = 0;

            for (int i = 0; i < AnswerCount; i++)
            {
                if (AnswerMap[i].GetAnswer() == 1)
                {
                    Score++;
                }
            }

            return Score;
        }
    }
}