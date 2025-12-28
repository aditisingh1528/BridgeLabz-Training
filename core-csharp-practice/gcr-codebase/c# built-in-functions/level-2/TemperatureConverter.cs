using System;

public class TemperatureConverter{
    static void Main(){
        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Convert to (C/F): ");
        char choice = Console.ReadLine()[0];

        if (choice == 'C' || choice == 'c')
            Console.WriteLine("Celsius: " + FahrenheitToCelsius(temp));
        else if (choice == 'F' || choice == 'f')
            Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(temp));
    }

    static double FahrenheitToCelsius(double f){
        return (f - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double c){
        return (c * 9 / 5) + 32;
    }
}
