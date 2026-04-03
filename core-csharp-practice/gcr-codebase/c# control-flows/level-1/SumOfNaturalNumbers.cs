using System;

public class SumOfNaturalNumbers{
	static void Main(){
		//Taking input fron user
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		//Checking if it is a natural number or not
		if(number < 0){
			Console.WriteLine("Not a natural number");
			return;
		}
		
		int whileSum = 0;
		int i = 1;
		
		while(i <= number){
			whileSum += i;
			i++;
		}
		
		int FormulaSum = number*(number + 1)/2;
		
		Console.WriteLine("The sum of natural numbers using while loop: " + whileSum);
		Console.WriteLine("The sum of natural numbers using formula: " + FormulaSum);
		Console.WriteLine(whileSum == FormulaSum ? "Correct" : "Incorrect");
	}
}