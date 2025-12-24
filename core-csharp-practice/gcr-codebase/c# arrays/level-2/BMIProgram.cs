using System;

public class BMIProgram{
    static void Main(){
		
		//taking inout
        Console.Write("Enter number of persons: ");
        int n = int.Parse(Console.ReadLine());
		
        double[] heights = new double[n];
        double[] weights = new double[n];
        double[] bmis = new double[n];
        string[] status = new string[n];
		
        for (int i = 0; i < n; i++){
            Console.WriteLine($"\nPerson {i + 1}:");
			
            Console.Write("Enter height in meters: ");
            heights[i] = double.Parse(Console.ReadLine());
			
            Console.Write("Enter weight in kg: ");
            weights[i] = double.Parse(Console.ReadLine());
			
            bmis[i] = weights[i] / (heights[i] * heights[i]);
			
            if (bmis[i] <= 18.4)
                status[i] = "Underweight";
            else if (bmis[i] <= 24.9)
                status[i] = "Normal";
            else if (bmis[i] <= 39.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }
		
        Console.WriteLine("\n--- BMI Report ---");
        for (int i = 0; i < n; i++){
            Console.WriteLine(
                $"Person {i + 1}: Height = {heights[i]} m, Weight = {weights[i]} kg, BMI = {bmis[i]:F2}, Status = {status[i]}"
            );
        }
    }
}
