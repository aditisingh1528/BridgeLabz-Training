using System;

public class Course
{
    // Instance variables
    string courseName;
    int duration;
    double fee;

    // Class variable
    static string instituteName = "BridgeLabz";

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method
    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Course: {courseName}, Duration: {duration} days, Fee: {fee}, Institute: {instituteName}");
    }

    // Class method
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }

    static void Main()
    {
        Course c1 = new Course("C#", 30, 15000);
        Course c2 = new Course("Java", 45, 18000);

        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();

        Course.UpdateInstituteName("Tech Academy");

        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
    }
}
