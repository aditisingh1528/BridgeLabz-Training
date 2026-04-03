using System;

public class QuotientRemainder
{
    public static void Main(string[] args)
    {
        //ask the user for first number
        Console.WriteLine("Enter first number: ");
        double Number1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double Number2=Convert.ToDouble(Console.ReadLine());

        double Quotient=Number1/Number2;
        double Remainder=Number1%Number2;

        Console.WriteLine("The Quotient is "+Quotient+" and Remainder is "+Remainder+" of two numbers "+Number1+" and "+Number2);
    }
}
