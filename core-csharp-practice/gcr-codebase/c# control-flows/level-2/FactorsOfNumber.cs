using System;

class FactorsOfNumber{
	
    static void Main(){
		
		//Taking input
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
		//Finding the factors of that number
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
			{
				//output
                Console.WriteLine(i);
            }
        }
    }
}
