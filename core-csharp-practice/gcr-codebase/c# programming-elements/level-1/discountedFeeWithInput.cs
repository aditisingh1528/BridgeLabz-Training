using System;

public class DiscountedFeeInput
{
    static void Main()
    {
        double fee, discountPercent;
		
		//taking input
        Console.Write("Enter Student Fee: ");
        fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter University Discount Percentage: ");
        discountPercent = Convert.ToDouble(Console.ReadLine());

        // calculating discount
        double discountAmount = (fee * discountPercent) / 100;
        double finalFee = fee - discountAmount;
		
        Console.WriteLine("The discount amount is INR " + discountAmount + " and final discounted fee is INR " + finalFee);
    }
}