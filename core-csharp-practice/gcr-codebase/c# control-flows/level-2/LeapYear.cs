using System;

public class LeapYear{
	static void Main(){
		// Taking input year from user
		Console.WriteLine("Enter the year: ");
		int year = int.Parse(Console.ReadLine());
		
		if (year < 1582)
        {
            Console.WriteLine("Year is not valid");
        }
        else if (year % 400 == 0){
            Console.WriteLine("Year is a Leap Year");
        }
        else if (year % 100 == 0){
            Console.WriteLine("Year is not a Leap Year");
        }
        else if (year % 4 == 0){
            Console.WriteLine("Year is a Leap Year");
        }
        else{
            Console.WriteLine("Year is not a Leap Year");
        }
	}
}