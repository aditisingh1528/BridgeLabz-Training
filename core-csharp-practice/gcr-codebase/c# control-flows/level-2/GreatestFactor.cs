using System;

class GreatestFactor{
	
    static void Main(){
		
		//Taking input number from user
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
        int greatestFactor = 1;
		
		//finding the greatest factor
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }
		//printing the output
        Console.WriteLine("Greatest factor besides itself is: " + greatestFactor);
    }
}
