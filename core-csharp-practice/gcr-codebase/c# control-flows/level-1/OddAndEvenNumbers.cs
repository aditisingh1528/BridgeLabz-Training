using System;

public class OddAndEvenNumbers{
	static void Main(){
		//Input from user
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		//checking for a natural number
		if(number <= 0){
			Console.WriteLine("Please enter a natural number: ");
			return;
		}
		
		for(int i = 1; i <= number; i++){
			if(i%2 == 0){
				Console.WriteLine(i + " is even");
			}
			else{
				Console.WriteLine(i + " is odd");
			}
		}
	}
}