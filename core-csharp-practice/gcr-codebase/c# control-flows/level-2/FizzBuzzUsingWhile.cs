using System;

public class FizzBuzz{
    static void Main(){
		
		//Taking input number from user
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
		//Ensuring that only positive integers are input
		if (number <= 0){
            Console.WriteLine("Please enter a positive integer");
            return;
        }

        int i = 1;
		//giving conditions for output
        while (i <= number){
            if (i % 3 == 0)
                Console.WriteLine("Fizz"); //if number is divisible by 3 then print fizz
            else if (i % 5 == 0)
                Console.WriteLine("Buzz"); //if number is divisible by 5 then print buzz
            else if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz"); //if number is divisible by 3 and 5 both then print fizzbuzz
            else
                Console.WriteLine(i); //print the number as it is

            i++;
        }
    }
}
