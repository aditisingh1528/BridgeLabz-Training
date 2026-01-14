using System;
using System.Diagnostics;

class SearchComparison
{
    static void Main()
    {
        int n = 1000000;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = i;

        int target = n - 1;

        Stopwatch sw = new Stopwatch();

        // Linear Search
        sw.Start();
        LinearSearch(arr, target);
        sw.Stop();
        Console.WriteLine("Linear Search Time: " + sw.ElapsedMilliseconds + " ms");

        // Binary Search
        sw.Restart();
        BinarySearch(arr, target);
        sw.Stop();
        Console.WriteLine("Binary Search Time: " + sw.ElapsedMilliseconds + " ms");
    }

    static int LinearSearch(int[] arr, int target)
    {
        foreach (int x in arr)
            if (x == target) return x;
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target) return mid;
            else if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }
}