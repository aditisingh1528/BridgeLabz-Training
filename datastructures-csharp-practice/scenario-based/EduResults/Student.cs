using System;

public class Student
{
    // Student marks
    private int Marks;

    // District of the student
    private string DistrictName;

    public Student(int Marks, string DistrictName)
    {
        this.Marks = Marks;
        this.DistrictName = DistrictName;
    }

    public int GetMarks()
    {
        return Marks;
    }

    public string GetDistrictName()
    {
        return DistrictName;
    }
}