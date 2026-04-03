using System;

class CountDigits{
    static void Main(){
		
		//taking input
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = 0;

        if (number == 0){
            count = 1;
        }
        else{
			
            while (number != 0){
                number = number / 10; // removing last digit
                count++;
            }
        }

        Console.WriteLine("Number of digits: " + count);
    }
}
