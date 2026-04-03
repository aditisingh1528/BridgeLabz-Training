using System;

public class BMIUsing2DArray{
    static void Main(){
        Console.Write("Enter number of persons: ");
        int number = int.Parse(Console.ReadLine());
		
        double[][] personData = new double[number][];
        string[] weightStatus = new string[number];
		
        for (int i = 0; i < number; i++){
            personData[i] = new double[3]; // [0]=Height, [1]=Weight, [2]=BMI
			
            Console.WriteLine($"\nPerson {i + 1}");
			
            // Height input
            while (true){
                Console.Write("Enter height in meters: ");
                personData[i][0] = double.Parse(Console.ReadLine());
                if (personData[i][0] > 0) break;
                Console.WriteLine("Height must be positive.");
            }
			
            // Weight input
            while (true){
                Console.Write("Enter weight in kg: ");
                personData[i][1] = double.Parse(Console.ReadLine());
                if (personData[i][1] > 0) break;
                Console.WriteLine("Weight must be positive.");
            }
			
            // BMI calculation
            personData[i][2] = personData[i][1] /
                               (personData[i][0] * personData[i][0]);
							   
            // Weight status
            if (personData[i][2] <= 18.4)
                weightStatus[i] = "Underweight";
            else if (personData[i][2] <= 24.9)
                weightStatus[i] = "Normal";
            else if (personData[i][2] <= 39.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }
		
        Console.WriteLine("\n--- BMI DETAILS ---");
        for (int i = 0; i < number; i++){
            Console.WriteLine(
                $"Person {i + 1}: Height = {personData[i][0]} m, " +
                $"Weight = {personData[i][1]} kg, " +
                $"BMI = {personData[i][2]:F2}, " +
                $"Status = {weightStatus[i]}"
            );
        }
    }
}
