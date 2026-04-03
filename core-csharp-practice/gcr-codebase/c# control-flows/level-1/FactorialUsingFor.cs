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
		
		double Fact = 1;
		for(int i = 1; i <= number; i++ ){
			Fact = Fact*i;
		}
		Console.WriteLine("The factorial of " + number + " is: " + Fact);
		
		
	}
}