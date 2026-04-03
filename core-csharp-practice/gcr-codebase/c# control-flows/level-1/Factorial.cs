using System;

public class Factorial{
	static void Main(){
		//Taking input integer from the user
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		if(number < 0){
			Console.WriteLine("Invalid");
			return;
		}
		int i = 1;
		double Fact = 1;
		while(i <= number){
			Fact = Fact*i;
			i++;
		}
		Console.WriteLine("The factorial of " + number + " is: " + Fact);
		
		
	}
}