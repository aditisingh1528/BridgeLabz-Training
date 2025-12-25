using System;

public class NumberAnalysis{
    static void Main(){
        int[] numbers = new int[5];

        // Take user input
        for (int i = 0; i < numbers.Length; i++){
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Check each number
        for (int i = 0; i < numbers.Length; i++){
            if (IsPositive(numbers[i])){
                if (IsEven(numbers[i]))
                    Console.WriteLine(numbers[i] + " is Positive and Even");
                else
                    Console.WriteLine(numbers[i] + " is Positive and Odd");
            }
            else{
                Console.WriteLine(numbers[i] + " is Negative");
            }
        }

        // Compare first and last elements
        int result = Compare(numbers[0], numbers[numbers.Length - 1]);

        if (result == 1)
            Console.WriteLine("First element is greater than last element");
        else if (result == 0)
            Console.WriteLine("First element is equal to last element");
        else
            Console.WriteLine("First element is less than last element");
    }

    // Check positive or negative
    static bool IsPositive(int number){
        return number >= 0;
    }

    // Check even or odd
    static bool IsEven(int number){
        return number % 2 == 0;
    }

    // Compare two numbers
    static int Compare(int number1, int number2){
        if (number1 > number2)
            return 1;
        else if (number1 == number2)
            return 0;
        else
            return -1;
    }
}
