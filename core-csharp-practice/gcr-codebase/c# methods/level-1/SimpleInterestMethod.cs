using System;

public class SimpleInterestProgram{
	
    // Method to calculate Simple Interest
    static double CalculateSimpleInterest(double principal, double rate, double time){
        return (principal * rate * time) / 100;
    }
	
    static void Main(){
        // Taking user inputs
        Console.Write("Enter Principal: ");
        double principal = double.Parse(Console.ReadLine());
		
        Console.Write("Enter Rate of Interest: ");
        double rate = double.Parse(Console.ReadLine());
		
        Console.Write("Enter Time: ");
        double time = double.Parse(Console.ReadLine());
		
        // Calculating simple interest
        double simpleInterest = CalculateSimpleInterest(principal, rate, time);
		
        // Displaying output
        Console.WriteLine(
            "The Simple Interest is " + simpleInterest +
            " for Principal " + principal +
            ", Rate of Interest " + rate +
            " and Time " + time
        );
    }
}
