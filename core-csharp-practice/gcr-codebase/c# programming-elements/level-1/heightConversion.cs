using System;

public class heightConversion{
    static void Main(){

        // taking input from user
        Console.Write("Enter your height in centimeters: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        // conversion
        double totalInches = heightInCm / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;

        // Output
        Console.WriteLine("Your Height in cm is " + heightInCm + " while in feet is " + feet + " and inches is " + inches);
    }
}
