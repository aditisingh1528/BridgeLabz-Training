using System;

class PowerOfNumber{
	
    static void Main(){
		
		//Taking input number from user
        Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
		
		//Taking input power from user
        Console.WriteLine("Enter the power: ");
        int power = int.Parse(Console.ReadLine());
		
        int result = 1;
		
		//finding the result
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }
		//Printing result
        Console.WriteLine("Result: " + result);
    }
}
