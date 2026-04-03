using System;

class MultiplicationTable{
    static void Main(){
		
		//Taking input number from user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
        int[] table = new int[10];
		
        // Storing the multiplication results
        for (int i = 1; i <= 10; i++){
            table[i - 1] = number * i;
        }
		
        // Displaying the table
        for (int i = 1; i <= 10; i++){
            Console.WriteLine($"{number} * {i} = {table[i - 1]}");
        }
    }
}