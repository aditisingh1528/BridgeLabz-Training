using System;

public class District
{
    // District name
    private string Name;

    // Students belonging to the district
    private Student[] Students;

    public District(string Name, Student[] Students)
    {
        this.Name = Name;
        this.Students = Students;
    }

    // Returns students of this district
    public Student[] GetStudents()
    {
        return Students;
    }
}