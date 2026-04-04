using System;

class QuickSortProductPrices
{
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high); // pivot index
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // choose last element as pivot
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            // place smaller elements to left
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }

    static void Main()
    {
        int[] prices = { 1200, 450, 800, 300 };
        QuickSort(prices, 0, prices.Length - 1);
        Console.WriteLine(string.Join(" ", prices));
    }
}