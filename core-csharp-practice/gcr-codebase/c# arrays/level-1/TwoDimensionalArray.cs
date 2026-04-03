using System;

public class TwoDimensionalArray{
	static void Main(){
		
		//Taking input for number of rows and columns
		Console.WriteLine("Enter the number of rows: ");
		int rows = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter the number of columns: ");
		int columns = int.Parse(Console.ReadLine());
		
		//Input of matrix elements
		int[,] matrix = new int[rows,columns];
		
		for(int i = 0; i < rows; i++){
			for(int j = 0; j < columns; j++){
				Console.WriteLine($"Enter matrix elements [{i},{j}]: ");
				matrix[i,j] = int.Parse(Console.ReadLine());
			}
		}
		
		int index = 0;
		//Initializing new 1D array
		int[] array = new int[rows * columns];
		
		//Putting values of 2D array in 1D array
		for(int i = 0; i < rows; i++){
			for(int j = 0; j < columns; j++){
				array[index] = matrix[i,j];
				index++;
			}
		}
		//Displaying the 1D array
		for(int i = 0; i < array.Length; i++){
			Console.Write(array[i] + " ");
		}
	}
}