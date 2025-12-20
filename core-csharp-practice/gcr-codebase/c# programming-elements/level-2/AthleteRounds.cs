using System;

public class AthleteRounds
{
    public static void Main(string[] args)
    {
        //take sides of the triangular park
        Console.WriteLine("Enter side1: ");
        double Side1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side2: ");
        double Side2=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side3: ");
        double Side3=Convert.ToDouble(Console.ReadLine());

        //calculate perimeter and rounds
        double Perimeter=Side1+Side2+Side3;
        double Rounds=5000/Perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is "+Rounds+" to complete 5 km");
    }
}
