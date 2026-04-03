using System;

public class FriendsComparison{
    static void Main(){
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Take user input
        for (int i = 0; i < 3; i++){
            Console.Write("Enter age of " + names[i] + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height of " + names[i] + " (in cm): ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        int youngestIndex = FindYoungest(ages);
        int tallestIndex = FindTallest(heights);

        Console.WriteLine("Youngest friend: " + names[youngestIndex]);
        Console.WriteLine("Tallest friend: " + names[tallestIndex]);
    }

    // Method to find youngest friend
    static int FindYoungest(int[] ages){
        int minIndex = 0;
        for (int i = 1; i < ages.Length; i++){
            if (ages[i] < ages[minIndex])
                minIndex = i;
        }
        return minIndex;
    }

    // Method to find tallest friend
    static int FindTallest(double[] heights){
        int maxIndex = 0;
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > heights[maxIndex])
                maxIndex = i;
        }
        return maxIndex;
    }
}
