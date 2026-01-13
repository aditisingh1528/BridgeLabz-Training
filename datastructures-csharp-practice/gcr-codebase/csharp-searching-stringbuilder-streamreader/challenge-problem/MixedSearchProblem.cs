using System;

class MixedSearchProblem
{
    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        bool[] visited = new bool[n + 1];

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0 && arr[i] <= n)
            {
                visited[arr[i]] = true;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            if (!visited[i])
            {
                return i;
            }
        }

        return n + 1;
    }
    static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of list:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter element " + (i + 1) + ":");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int missing = FindFirstMissingPositive(arr);
        Console.WriteLine("First missing positive integer: " + missing);

        Array.Sort(arr);

        Console.WriteLine("Enter target value to search:");
        int target = Convert.ToInt32(Console.ReadLine());

        int index = BinarySearch(arr, target);

        if (index != -1)
        {
            Console.WriteLine("Target found at index (after sorting): " + index);
        }
        else
        {
            Console.WriteLine("Target not found");
        }
	}
}
