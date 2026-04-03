using System;

public class distanceConversion{
	static void Main(){
		//define distance in kilometres
		double distanceInKm = 10.8;
		//Covert in miles
		double distanceInMiles = distanceInKm*1.6;
		//print the result
		Console.WriteLine("The Distance 10.8 km in Miles is " + distanceInMiles);
	}
}