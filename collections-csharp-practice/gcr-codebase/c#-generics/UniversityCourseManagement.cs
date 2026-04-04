using System;
using System.Collections.Generic;

// Base Course Type
abstract class CourseType
{
    public abstract void Evaluate();
}

class ExamCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine("Evaluation via Exam");
    }
}

class AssignmentCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine("Evaluation via Assignment");
    }
}

// Generic Course
class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    public void EvaluateAll()
    {
        foreach (var course in courses)
            course.Evaluate();
    }
}

class Program
{
    static void Main()
    {
        Course<ExamCourse> examCourses = new Course<ExamCourse>();
        examCourses.AddCourse(new ExamCourse());
        examCourses.EvaluateAll();
    }
}