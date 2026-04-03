using System;

public class UnitConvertor{
    // Convert kilometers to miles
    public static double ConvertKmToMiles(double km){
        double km2miles = 0.621371;
        return km * km2miles;
    }

    // Convert miles to kilometers
    public static double ConvertMilesToKm(double miles){
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    // Convert meters to feet
    public static double ConvertMetersToFeet(double meters){
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    // Convert feet to meters
    public static double ConvertFeetToMeters(double feet){
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }

    // Test the utility methods
    static void Main(){
        Console.Write("Enter kilometers: ");
        double km = double.Parse(Console.ReadLine());
        Console.WriteLine("Miles: " + ConvertKmToMiles(km));

        Console.Write("Enter miles: ");
        double miles = double.Parse(Console.ReadLine());
        Console.WriteLine("Kilometers: " + ConvertMilesToKm(miles));

        Console.Write("Enter meters: ");
        double meters = double.Parse(Console.ReadLine());
        Console.WriteLine("Feet: " + ConvertMetersToFeet(meters));

        Console.Write("Enter feet: ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine("Meters: " + ConvertFeetToMeters(feet));
    }
}
