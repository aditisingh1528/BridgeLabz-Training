using System;

public class Factors{
	static void Main(){
		
		//Taking input number
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		int maxFactor = 10;
		int[] factors = new int[maxFactor];
		int index = 0;
		
		
		for(int i = 1; i < number; i++){
			if(number % i == 0){
				if (index == maxFactor){
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];

                    for (int j = 0; j < factors.Length; j++){
                        temp[j] = factors[j];
                    }

                    factors = temp;
                }

                factors[index] = i;
                index++;
			}
		}
		Console.WriteLine("All the factors of " + number + " are: ");
		for(int i = 0; i < index; i++){
			Console.Write(factors[i] + " ");
		}
	}
}