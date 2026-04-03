using System;

class ArmstrongNumber{
    static void Main(){
		
		//taking input from user
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
        int originalNumber = number;
        int sum = 0;
		
        while (originalNumber != 0){
            int remainder = originalNumber % 10;   // getting last digit
            sum += remainder * remainder * remainder; // cubing and adding
            originalNumber = originalNumber / 10;  // removing last digit
        }
		
        if (sum == number)
            Console.WriteLine(number + " is an Armstrong number");
        else
            Console.WriteLine(number + " is not an Armstrong number");
    }
}
