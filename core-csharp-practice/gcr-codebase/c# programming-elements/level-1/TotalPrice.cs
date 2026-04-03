using System;

public class TotalPrice
{
    public static void Main(string[] args)
    {
        //ask user for unit price
        Console.WriteLine("Enter price of a single unit: ");
        double UnitPrice=Convert.ToDouble(Console.ReadLine());
		//ask user for quantity
        Console.WriteLine("Enter total quantity");
        double Quantity=Convert.ToDouble(Console.ReadLine());

        //calculate total price
        double TotalPriceValue=UnitPrice*Quantity;

        Console.WriteLine("The total purchase price is "+TotalPriceValue+" if the quantity is "+Quantity+" and unit price is "+UnitPrice);
    }
}
