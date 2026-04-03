using System;

public class MeanHeight{
	static void Main(){
		double[] heights = new double[11];
		double sumOfHeights = 0.0;
		
		//Taking input for heights of all 11 players
		for(int i = 0; i < heights.Length; i++){
			Console.WriteLine($"Enter height of player {i + 1}: ");
			heights[i] = double.Parse(Console.ReadLine());
			//Finding sum of all the heights
			sumOfHeights += heights[i];
		}
		//Calculating mean of heights
		double meanHeight = sumOfHeights/heights.Length;
		
		//Output
		Console.WriteLine("The mean height of the football team: " + meanHeight);
	}
}