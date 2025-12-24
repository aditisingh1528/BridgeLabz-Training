using System;

class FizzBuzz2{
    static void Main(){
        // Taking input from user
        Console.WriteLine("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Checking if the number is a positive integer
        if (number <= 0){
            Console.WriteLine("Please enter a positive integer");
            return;
        }
        string[] result = new string[number];
		
        // Looping from 1 to number and saving values in array
        for (int i = 1; i <= number; i++){
            if (i % 3 == 0 && i % 5 == 0){
                result[i - 1] = "FizzBuzz";
            }
            else if (i % 3 == 0){
                result[i - 1] = "Fizz";
            }
            else if (i % 5 == 0){
                result[i - 1] = "Buzz";
            }
            else{
                result[i - 1] = i.ToString();
            }
        } 
        for (int i = 0; i < result.Length; i++){	// Printing the result array with position
            Console.WriteLine("Position " + (i + 1) + " = " + result[i]);
        }
    }
}