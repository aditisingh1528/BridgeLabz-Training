using System;

public class PrimeNumber{
	static void Main(){
		
		//taking input number from user
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		bool isPrime = true;
		
		//if a number is 1 or less than 1 then it is not prime
		if(number <= 1){
			isPrime = false;
		}
		
		else{
		//checking if a number is divisible by any other number other than 1 or itself
			for(int i = 2; i < number; i++){
				if(number%i==0){
					isPrime = false;
					break;
				}
			}
		}
		if(isPrime)
			Console.WriteLine(number + " is a prime number.");
		else
			Console.WriteLine(number + " is not a prime number.");
	}
}