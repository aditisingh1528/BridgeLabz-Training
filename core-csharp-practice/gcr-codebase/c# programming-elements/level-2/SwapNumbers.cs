using System;

public class SwapNumbers
{
    public static void Main(string[] args)
    {
        //take two numbers as input
        Console.WriteLine("Enter first number: ");
        int Num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int Num2=Convert.ToInt32(Console.ReadLine());

        //swapping using temporary variable
        int Temp=Num1;
        Num1=Num2;
        Num2=Temp;

        Console.WriteLine("The swapped numbers are "+Num1+" and "+Num2);
    }
}
