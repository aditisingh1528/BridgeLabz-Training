using System;

public class DigitArrayLargest{
    static void Main(){
		
		//Taking Input
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
		
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;
		
        // Storing digits in array
        while (number != 0){
            if (index == maxDigit)
                break;
			
            digits[index] = number % 10;
            number = number / 10;
            index++;
        }
		
        int largest = 0;
        int secondLargest = 0;

        // Finding largest and second largest
        for (int i = 0; i < index; i++){
            if (digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i];
            }
        }
		
        // Output
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}
