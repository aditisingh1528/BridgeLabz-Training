using System;

public class SpringSeason{
	static void Main(){
		//Taking input date and month from user
		Console.WriteLine("Enter the month: ");
		int month = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter the date: ");
		int date = int.Parse(Console.ReadLine());
		
		bool spring = (month == 3 && date >= 20) || (month == 4) || (month == 5) || (month == 6  && date <= 20);
		
		if(spring){
			Console.WriteLine("It's a Spring Season");
		}
		else{
			Console.WriteLine("Not a Spring Season");
		}
	}
}