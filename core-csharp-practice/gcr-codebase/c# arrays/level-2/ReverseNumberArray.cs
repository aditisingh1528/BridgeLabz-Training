using System;

class ReverseNumberArray{
    static void Main(){
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
		
        int temp = number;
        int count = 0;
		
        //Counting digits
        while (temp != 0){
            count++;
            temp = temp / 10;
        }
		
        int[] digits = new int[count];
        int[] reverseDigits = new int[count];
		
        //Storing digits in array (original order)
        temp = number;
        for (int i = count - 1; i >= 0; i--){
            digits[i] = temp % 10;
            temp = temp / 10;
        }
		
        //Storing digits in reverse order array
        for (int i = 0; i < count; i++){
            reverseDigits[i] = digits[count - 1 - i];
        }
		
        //Displaying reversed number
        Console.WriteLine("Reversed Number:");
        for (int i = 0; i < count; i++){
            Console.Write(reverseDigits[i]);
        }
    }
}
