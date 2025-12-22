using System;

public class CheckDivisibility{
	static void Main(){
		
		Console.WriteLine("Enter a number: ");
		
		//Taking the input number from user
		int num = int.Parse(Console.ReadLine());
		
		//Output
		if(num%5==0){
			Console.WriteLine("Is the number " + num + " divisible by 5? YES" );
		}
		else{
			Console.WriteLine("Is the number " + num + " divisible by 5? NO" );
		}
	}
}