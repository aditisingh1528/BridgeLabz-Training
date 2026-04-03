using System;

public class DigitFrequency{
    static void Main(string[] args){
        //Taking number input from user
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());
		
        //Storing the original number for reference
        long temp = number;
		
        //Finding the count of digits
        int count = 0;
        while (temp > 0){
            count++;
            temp /= 10;
        }
		
        //Creating array to store digits
        int[] digits = new int[count];
        temp = number;
		
        //Storing each digit in array
        for (int i = 0; i < count; i++){
            digits[i] = (int)(temp % 10);
            temp /= 10;
        }
		
        // Frequency array for digits 0–9
        int[] frequency = new int[10];
		
        // Calculating frequency of each digit
        for (int i = 0; i < count; i++){
            frequency[digits[i]]++;
        }
		
        //Displaying frequency
        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < 10; i++){
            if (frequency[i] > 0){
                Console.WriteLine("Digit " + i + " occurs " + frequency[i] + " time(s)");
            }
        }
    }
}
