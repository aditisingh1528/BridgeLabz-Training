using System;

public class LeapYearCheck{
    static void Main(){
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        // Check for Gregorian calendar validity
        if (year < 1582){
            Console.WriteLine("Leap Year calculation is valid only for year >= 1582.");
            return;
        }

        if (IsLeapYear(year))
            Console.WriteLine(year + " is a Leap Year.");
        else
            Console.WriteLine(year + " is not a Leap Year.");
    }

    // Method to check leap year
    static bool IsLeapYear(int year){
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
