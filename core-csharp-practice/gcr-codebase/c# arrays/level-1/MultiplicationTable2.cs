using System;

public class MultiplicationTable2{
    static void Main(){
		
		//Taking input number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
        int[] multiplicationResult = new int[4]; // for 6 to 9
		
        // Storing results
        for (int i = 6; i <= 9; i++){
            multiplicationResult[i - 6] = number * i;
        }
		
        // Displaying results
        for (int i = 6; i <= 9; i++){
            Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
        }
    }
}