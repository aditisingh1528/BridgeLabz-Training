using System;

class AbundantNumber{
    static void Main(){
		
		//taking input
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
        int sum = 0;

        for (int i = 1; i < number; i++){
            if (number % i == 0){
                sum += i;
            }
        }
		//output
        if (sum > number)
            Console.WriteLine(number + " is an Abundant Number");
        else
            Console.WriteLine(number + " is not an Abundant Number");
    }
}
