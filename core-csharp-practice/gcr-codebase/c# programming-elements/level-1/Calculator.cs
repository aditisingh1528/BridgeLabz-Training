using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        //take user input for operands
        Console.WriteLine("Enter smaller number");
        double Number1=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter larger number");
        double Number2=Convert.ToDouble(Console.ReadLine());

        //perform calculations
        double Sum=Number1+Number2;
        double Difference=Number2-Number1;

        double Multiplication=Number1*Number2;
        double Division=Number2/Number1;

		//print the result
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+Number1+" and "+Number2+" is "+Sum+", "+Difference+", "+Multiplication+", and "+Division);
    }

}