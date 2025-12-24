using System;

class NumberCheck{
    static void Main(){
        int[] numbers = new int[5];
		
        // Taking input of five numbers
        for (int i = 0; i < numbers.Length; i++){
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
		
        // Checking each number if it is positive, negative or zero
        for (int i = 0; i < numbers.Length; i++){
            if (numbers[i] > 0){
				//Checking if the positive number is even or odd
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i] + " is Positive and Even");
                else
                    Console.WriteLine(numbers[i] + " is Positive and Odd");
            }
            else if (numbers[i] < 0){
                Console.WriteLine(numbers[i] + " is Negative");
            }
            else{
                Console.WriteLine(numbers[i] + " is Zero");
            }
        }
		
        // Comparing first and last element
        if (numbers[0] == numbers[4])
            Console.WriteLine("First and last elements are Equal");
        else if (numbers[0] > numbers[4])
            Console.WriteLine("First element is Greater than last element");
        else
            Console.WriteLine("First element is Less than last element");
    }
}
