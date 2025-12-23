using System;

public class MultiplesBelowHundred{
    static void Main(){
		
		//Taking input number
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
		//Finding Multiples of the number
        for (int i = 100; i >= 1; i--){
            if (i % number == 0){
				//output
                Console.WriteLine(i);
            }
        }
    }
}
