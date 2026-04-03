using System;

public class FootballTeamHeights
{
    static void Main()
    {
        int[] heights = GenerateHeights(11);

        int sum = FindSum(heights);
        double mean = FindMean(heights);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine("Player Heights (cm):");
        foreach (int h in heights)
        {
            Console.Write(h + " ");
        }

        Console.WriteLine("\n\nResults:");
        Console.WriteLine("Shortest Height: " + shortest + " cm");
        Console.WriteLine("Tallest Height : " + tallest + " cm");
        Console.WriteLine("Mean Height    : " + mean + " cm");
    }

    // Generate random heights between 150 and 250 cm
    static int[] GenerateHeights(int size)
    {
        int[] heights = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(150, 251);
        }
        return heights;
    }

    // Find sum of heights
    static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int h in heights)
        {
            sum += h;
        }
        return sum;
    }

    // Find mean height
    static double FindMean(int[] heights)
    {
        return (double)FindSum(heights) / heights.Length;
    }

    // Find shortest height
    static int FindShortest(int[] heights)
    {
        int min = heights[0];
        foreach (int h in heights)
        {
            if (h < min)
                min = h;
        }
        return min;
    }

    // Find tallest height
    static int FindTallest(int[] heights)
    {
        int max = heights[0];
        foreach (int h in heights)
        {
            if (h > max)
                max = h;
        }
        return max;
    }
}
