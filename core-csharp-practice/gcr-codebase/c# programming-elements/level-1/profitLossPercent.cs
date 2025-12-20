using System;

public class profitLossPercent{
	static void Main(){
		double sellingPrice = 129;
		double costPrice = 191;
		double profit = costPrice - sellingPrice;
		double profitPercent = (profit/costPrice) * 100;
		Console.WriteLine("The cost price is INR " +costPrice +"and the sellingPrice is INR "+sellingPrice +"\n The profit is INR "+profit +" and the profitPercent "+profitPercent );
	}
}