using System;

namespace ExamProctorApp
{
    public class QuestionAnswer
    {
        private int QuestionID;
        private int Answer;

        public QuestionAnswer(int QuestionID, int Answer)
        {
            this.QuestionID = QuestionID;
            this.Answer = Answer;
        }

        public int GetQuestionID()
        {
            return QuestionID;
        }

        public int GetAnswer()
        {
            return Answer;
        }
    }
}