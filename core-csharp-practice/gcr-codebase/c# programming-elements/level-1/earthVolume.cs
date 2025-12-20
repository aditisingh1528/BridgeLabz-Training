using System;

public class earthVolume{

    static void Main(string[] args)
    {
		int radius=6378;
        double pi=3.14;

        //calculating the volume of earth
        double volume=(4.0/3)*pi*radius*radius*radius;

        //converting volume into miles
        double inMiles=volume*1.6;
        Console.WriteLine("The volume of earth in cubic kilometers is "+volume +" and cubic miles is "+ inMiles);
    }
}