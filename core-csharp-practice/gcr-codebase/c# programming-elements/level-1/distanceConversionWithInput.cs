using System;

public class kmToMiles{
	static void Main(){
		double km;
		
		//taking input from user
		Console.Write("Enter the distance in kilometers: ");
		km = Convert.ToDouble(Console.ReadLine());
		
		double miles = km/1.6;
		Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
	}
}
