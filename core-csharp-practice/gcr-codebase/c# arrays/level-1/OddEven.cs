using System;

public class OddEven{
	static void Main(){
		
		//Taking input number
		Console.WriteLine("Enter a number: ");
		int number = int.Parse(Console.ReadLine());
		
		if(number <= 0){
			Console.WriteLine("Please enter a natural number");
			return;
		}
		
		//Creating odd and even arrays
		int[] odd = new int[number/2+1];
		int[] even = new int[number/2+1];
		
		//creating odd and even index variables
		int oddIndex = 0;
		int evenIndex = 0;
		
		//storing all the even numbers in even array
		for(int i = 0; i  <= number; i++){
			if(i%2 == 0){
				even[evenIndex] = i;
				evenIndex++;
			}
			//storing odd numbers in odd array
			else{
				odd[oddIndex] = i;
				oddIndex++;
			}
		}
		//Printing the odd numbers
		Console.WriteLine("Odd Numbers: ");
		for(int i = 0; i < oddIndex; i++){
			Console.Write(odd[i] + " ");
		}
		
		Console.WriteLine();
		//Printing the even numbers
		Console.WriteLine("Even Numbers: ");
		for(int i = 0; i < evenIndex; i++){
			Console.Write(even[i] + " ");
		}
	}
}