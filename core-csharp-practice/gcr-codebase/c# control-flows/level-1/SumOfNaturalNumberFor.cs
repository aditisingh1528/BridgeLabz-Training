using System;

public class SumOfNaturalNumberFor{
	static void Main(){
		//Taking input fron user
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		//Checking if it is a natural number or not
		if(number < 0){
			Console.WriteLine("Not a natural number");
			return;
		}
		int ForSum = 0;
		for(int i = 1; i <= number; i++){
			ForSum += i; 
		}
		
		int FormulaSum = number*(number + 1)/2;
		
		Console.WriteLine("The sum of natural numbers using while loop: " + ForSum);
		Console.WriteLine("The sum of natural numbers using formula: " + FormulaSum);
		Console.WriteLine(ForSum == FormulaSum ? "Correct" : "Incorrect");
	}
}