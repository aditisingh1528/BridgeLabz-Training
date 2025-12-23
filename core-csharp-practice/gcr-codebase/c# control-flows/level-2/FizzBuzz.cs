using System;

public class FizzBuzz{
	static void Main(){
		
		//taking an input from user
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		if(number <= 0){
			Console.WriteLine("Please enter a positive integer");
		}
		
		for(int i = 1; i <= number; i++){
			if(i%3==0)
				Console.WriteLine("Fizz");
			else if(i%5==0)
				Console.WriteLine("Buzz");
			else if(i%3==0 && i%5==0)
				Console.WriteLine("FizzBuzz");
			else
				Console.WriteLine(i);
		}
	}
}