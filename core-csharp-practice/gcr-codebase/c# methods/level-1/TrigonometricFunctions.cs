using System;

public class TrigonometricFunctions{
    static void Main()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());
		
        double[] results = CalculateTrigonometricFunctions(angle);
		
        Console.WriteLine("Sine: " + results[0]);
        Console.WriteLine("Cosine: " + results[1]);
        Console.WriteLine("Tangent: " + results[2]);
    }
	
    // Method to calculate trigonometric functions
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert degrees to radians
        double radians = angle * Math.PI / 180;

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);
		
        return new double[] { sine, cosine, tangent };
    }
}
