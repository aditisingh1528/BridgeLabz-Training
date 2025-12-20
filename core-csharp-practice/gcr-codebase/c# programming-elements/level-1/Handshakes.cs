using System;

public class Handshakes
{
    public static void Main(string[] args)
    {
        //ask user for number of students
        Console.WriteLine("Enter number of students: ");
        double NumberOfStudents=Convert.ToDouble(Console.ReadLine());

        //calculate total number of handshakes
        double Handshakes=(NumberOfStudents*(NumberOfStudents-1))/2;

        Console.WriteLine("Total number of possible handshakes for "+NumberOfStudents+" is "+Handshakes);
    }
}
