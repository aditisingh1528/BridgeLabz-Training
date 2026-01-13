using System;

class FirstAndLastOccurrence
{
    static int FindFirst(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                high = mid - 1;
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

        return result;
    }
    static int FindLast(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                low = mid + 1;
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

        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of array:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter element " + (i + 1) + ":");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter target element:");
        int target = Convert.ToInt32(Console.ReadLine());

        int first = FindFirst(arr, target);
        int last = FindLast(arr, target);

        if (first != -1)
        {
            Console.WriteLine("First occurrence at index: " + first);
            Console.WriteLine("Last occurrence at index: " + last);
        }
        else
        {
            Console.WriteLine("Element not found in array");
        }
    }
}