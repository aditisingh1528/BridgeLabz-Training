using System;

public class FahrenheitToCelsius
{
    public static void Main(string[] args)
    {
        //take temperature in fahrenheit
        Console.WriteLine("Enter temperature in Fahrenheit: ");
        double Fahrenheit=Convert.ToDouble(Console.ReadLine());

        //convert to celsius
        double Celsius=(Fahrenheit-32)*5/9;

        Console.WriteLine("The "+Fahrenheit+" Fahrenheit is "+Celsius+" Celsius");
    }
}
