using System;

public class FriendsComparison{
    static void Main(){
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] age = new int[3];
        double[] height = new double[3];
		
        //Taking Input
        for (int i = 0; i < 3; i++){
            Console.WriteLine($"Enter age of {names[i]}:");
            age[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter height of {names[i]}:");
            height[i] = double.Parse(Console.ReadLine());
        }
		
        // Finding youngest and tallest
        int youngestIndex = 0;
        int tallestIndex = 0;
		
        for (int i = 1; i < 3; i++){
            if (age[i] < age[youngestIndex])
                youngestIndex = i;

            if (height[i] > height[tallestIndex])
                tallestIndex = i;
        }
		
        // Output
        Console.WriteLine("Youngest Friend: " + names[youngestIndex]);
        Console.WriteLine("Tallest Friend: " + names[tallestIndex]);
    }
}
