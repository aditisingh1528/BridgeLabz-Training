using System;

public class CheckLargest{
	static void Main(){
		//Taking input of three numbers from user
		Console.WriteLine("Enter the first number: ");
		int num1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter the second number: ");
		int num2 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter the third number: ");
		int num3 = int.Parse(Console.ReadLine());
		
		//checking which number is largest
		bool FirstLargest = num1 > num2 && num1 > num3;
		bool SecondLargest = num2 > num1 && num2 > num3;
		bool ThirdLargest = num3 > num1 && num3 > num2;
		
		//printing output
		Console.WriteLine("Is the first number largest? " + FirstLargest);
		Console.WriteLine("Is the second number largest? " + SecondLargest);
		Console.WriteLine("Is the third number largest? " + ThirdLargest);
	}
}