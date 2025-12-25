using System;

class Handshakes{
    static void Main(){
        Console.Write("Enter number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        int possibleHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        Console.WriteLine("Number of possible handshakes: " + possibleHandshakes);
    }
}
