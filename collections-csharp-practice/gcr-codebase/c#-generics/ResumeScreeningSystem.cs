using System;
using System.Collections.Generic;

// Base Job Role
abstract class JobRole
{
    public abstract void Screen();
}

class SoftwareEngineer : JobRole
{
    public override void Screen()
    {
        Console.WriteLine("Screening Software Engineer Resume");
    }
}

class DataScientist : JobRole
{
    public override void Screen()
    {
        Console.WriteLine("Screening Data Scientist Resume");
    }
}

// Generic Resume Processor
class Resume<T> where T : JobRole
{
    private List<T> resumes = new List<T>();

    public void AddResume(T role)
    {
        resumes.Add(role);
    }

    public void ProcessResumes()
    {
        foreach (var resume in resumes)
            resume.Screen();
    }
}

class Program
{
    static void Main()
    {
        Resume<SoftwareEngineer> seResumes = new Resume<SoftwareEngineer>();
        seResumes.AddResume(new SoftwareEngineer());
        seResumes.ProcessResumes();
    }
}