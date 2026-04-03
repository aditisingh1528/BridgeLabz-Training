using System;

public class CelsiusToFahrenheit
{
    public static void Main(string[] args)
    {
        //take temperature in celsius
        Console.WriteLine("Enter temperature in Celsius: ");
        double Celsius=Convert.ToDouble(Console.ReadLine());

        //convert to fahrenheit
        double Fahrenheit=(Celsius*9/5)+32;

        Console.WriteLine("The "+Celsius+" Celsius is "+Fahrenheit+" Fahrenheit");
    }
}
