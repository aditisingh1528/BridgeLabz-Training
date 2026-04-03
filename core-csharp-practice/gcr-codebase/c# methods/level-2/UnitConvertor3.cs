using System;

public class UnitConvertor3{
    // Convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheit){
        double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
        return fahrenheit2celsius;
    }

    // Convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsius){
        double celsius2fahrenheit = (celsius * 9 / 5) + 32;
        return celsius2fahrenheit;
    }

    // Convert pounds to kilograms
    public static double ConvertPoundsToKilograms(double pounds){
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Convert kilograms to pounds
    public static double ConvertKilogramsToPounds(double kilograms){
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Convert gallons to liters
    public static double ConvertGallonsToLiters(double gallons){
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Convert liters to gallons
    public static double ConvertLitersToGallons(double liters){
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }

    // Test the utility methods
    static void Main(){
        Console.WriteLine("Fahrenheit to Celsius: " + ConvertFahrenheitToCelsius(98.6));
        Console.WriteLine("Celsius to Fahrenheit: " + ConvertCelsiusToFahrenheit(37));
        Console.WriteLine("Pounds to Kilograms: " + ConvertPoundsToKilograms(10));
        Console.WriteLine("Kilograms to Pounds: " + ConvertKilogramsToPounds(5));
        Console.WriteLine("Gallons to Liters: " + ConvertGallonsToLiters(2));
        Console.WriteLine("Liters to Gallons: " + ConvertLitersToGallons(5));
    }
}
