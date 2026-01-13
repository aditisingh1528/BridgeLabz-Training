using System;

class PeakElement
{
    static int FindPeak(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            bool leftOk = (mid == 0) || (arr[mid] > arr[mid - 1]);
            bool rightOk = (mid == arr.Length - 1) || (arr[mid] > arr[mid + 1]);

            if (leftOk && rightOk)
            {
                return mid;
            }
            else if (mid < arr.Length - 1 && arr[mid] < arr[mid + 1])
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
        Console.WriteLine("Enter size of array:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter element " + (i + 1) + ":");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int index = FindPeak(arr);

        if (index != -1)
        {
            Console.WriteLine("Peak element found at index: " + index);
            Console.WriteLine("Peak element value: " + arr[index]);
        }
        else
        {
            Console.WriteLine("No peak element found");
        }
    }

}