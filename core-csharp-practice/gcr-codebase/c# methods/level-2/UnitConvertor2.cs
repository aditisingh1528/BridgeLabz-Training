using System;

public class UnitConvertor2{
    // Convert yards to feet
    public static double ConvertYardsToFeet(double yards){
        double yards2feet = 3;
        return yards * yards2feet;
    }

    // Convert feet to yards
    public static double ConvertFeetToYards(double feet){
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    // Convert meters to inches
    public static double ConvertMetersToInches(double meters){
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    // Convert inches to meters
    public static double ConvertInchesToMeters(double inches){
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    // Convert inches to centimeters
    public static double ConvertInchesToCentimeters(double inches){
        double inches2cm = 2.54;
        return inches * inches2cm;
    }

    // Test methods
    static void Main(){
        Console.WriteLine("Yards to Feet: " + ConvertYardsToFeet(2));
        Console.WriteLine("Feet to Yards: " + ConvertFeetToYards(6));
        Console.WriteLine("Meters to Inches: " + ConvertMetersToInches(1));
        Console.WriteLine("Inches to Meters: " + ConvertInchesToMeters(10));
        Console.WriteLine("Inches to Centimeters: " + ConvertInchesToCentimeters(10));
    }
}
