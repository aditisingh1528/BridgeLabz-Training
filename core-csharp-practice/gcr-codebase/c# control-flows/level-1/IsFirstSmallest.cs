using System;

public class IsFirstSmallest{

	static void Main(string[] args){
        //Taking inputs of three numbers from user
		Console.WriteLine("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        bool result = (num1 < num2 && num1 < num3);

        Console.WriteLine("Is the first number the samllest? " + result);
    }
}