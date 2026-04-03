using System;

class NumberCheck{
	
    static void Main(){
		//Taking input
		Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
		//checking if the number is negative, positive or zero and printing output
        if (number > 0)
            Console.WriteLine("positive");
        else if (number < 0)
            Console.WriteLine("negative");
        else
            Console.WriteLine("zero");
    }
}
