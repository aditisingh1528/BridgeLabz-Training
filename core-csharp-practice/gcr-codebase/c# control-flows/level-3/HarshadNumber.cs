using System;

class HarshadNumber{
    static void Main(){
		
		//taking input
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
        int sum = 0;
        int temp = number;
		
        while (temp != 0){
            sum += temp % 10;   // adding digit
            temp = temp / 10;   // removing last digit
        }
		
		//output
        if (number % sum == 0)
            Console.WriteLine(number + " is a Harshad Number");
        else
            Console.WriteLine(number + " is not a Harshad Number");
    }
}
