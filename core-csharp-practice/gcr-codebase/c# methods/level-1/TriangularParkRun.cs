using System;

public class TriangularParkRun{
    static double CalculateRounds(double side1, double side2, double side3){
        double perimeter = side1 + side2 + side3;
        double totalDistance = 5000; // 5 km in meters
        return totalDistance / perimeter;
    }
	
    static void Main(){
        Console.Write("Enter side 1 (in meters): ");
        double side1 = double.Parse(Console.ReadLine());
		
        Console.Write("Enter side 2 (in meters): ");
        double side2 = double.Parse(Console.ReadLine());
		
        Console.Write("Enter side 3 (in meters): ");
        double side3 = double.Parse(Console.ReadLine());
		
        double rounds = CalculateRounds(side1, side2, side3);
		
        Console.WriteLine("Number of rounds to complete 5 km: " + rounds);
    }
}
