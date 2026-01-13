using System;

class RotationPoint
{
    static int FindRotationPoint(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] > arr[high])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
			}
        
		}

        return low;
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

        int index = FindRotationPoint(arr);

        Console.WriteLine("Index of smallest element: " + index);
        Console.WriteLine("Smallest element: " + arr[index]);
    }
}