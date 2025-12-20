using System;

public class discontedFee{
	static void Main(){
		int fee = 125000;
		int discountPercent = 10;
		double discountedAmount = (fee*discountPercent)/100;
		double feeToPay = fee - discountedAmount;
		
		//Print the result
		Console.WriteLine("The discount amount is INR "+discountedAmount+ " and final discounted fee is INR "+feeToPay );
		
	}
}