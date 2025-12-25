using System;

public class WindChillCalculator{
    static void Main(){
        Console.Write("Enter temperature: ");
        double temperature = double.Parse(Console.ReadLine());
		
        Console.Write("Enter wind speed: ");
        double windSpeed = double.Parse(Console.ReadLine());
		
        double windChill = CalculateWindChill(temperature, windSpeed);
		
        Console.WriteLine("Wind Chill Temperature: " + windChill);
    }
	
    // Method to calculate wind chill temperature
    public static double CalculateWindChill(double temperature, double windSpeed){
        double windChill = 35.74 
                           + 0.6215 * temperature 
                           + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
						   
        return windChill;
    }
}
