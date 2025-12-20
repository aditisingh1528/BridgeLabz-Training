using System;

public class WeightConversion
{
    public static void Main(string[] args)
    {
        //take weight in pounds as input
        Console.WriteLine("Enter weight in pounds: ");
        double Pounds=Convert.ToDouble(Console.ReadLine());

        //convert pounds to kilograms
        double Kilograms=Pounds/2.2;

        Console.WriteLine("The weight of the person in pounds is "+Pounds+" and in kg is "+Kilograms);
    }
}
