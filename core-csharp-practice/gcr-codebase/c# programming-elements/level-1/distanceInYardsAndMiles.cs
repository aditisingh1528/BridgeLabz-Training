using System;

public class distanceInYardsAndMiles
{
    static void Main()
    {
        double distanceInFeet;

        
        Console.Write("Enter distance in feet: ");
        distanceInFeet = Convert.ToDouble(Console.ReadLine());// take input from user

        // converting feet to yards
        double distanceInYards = distanceInFeet / 3;

        // converting yards to miles
        double distanceInMiles = distanceInYards / 1760;

        // printing the result
        Console.WriteLine(
            "The distance in feet is " + distanceInFeet +" while in yards is " + distanceInYards +
            " and miles is " + distanceInMiles
        );
    }
}
