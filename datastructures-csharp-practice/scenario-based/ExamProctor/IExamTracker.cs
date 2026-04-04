using System;

namespace ExamProctorApp
{
    public interface IExamTracker
    {
        void VisitQuestion(int QID);
        void SaveAnswer(int QuestionID, int Answer);
        int EvaluateScore();
    }
}