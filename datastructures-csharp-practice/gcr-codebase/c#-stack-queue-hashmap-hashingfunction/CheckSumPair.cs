using System;
using System.Collections.Generic;

class CheckSumPair
{
    // Finds if any two elements sum to target
    static void FindPair(int[] arr, int target)
    {
        HashSet<int> set = new HashSet<int>(); // Stores visited numbers

        foreach (int num in arr)
        {
            if (set.Contains(target - num)) // Check complement
            {
                Console.WriteLine("Pair Found");
                return;
            }
            set.Add(num); // Add current element
        }

        Console.WriteLine("Pair Not Found");
    }

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the target sum:");
        int target = int.Parse(Console.ReadLine());

        FindPair(arr, target); // Function call
    }
}