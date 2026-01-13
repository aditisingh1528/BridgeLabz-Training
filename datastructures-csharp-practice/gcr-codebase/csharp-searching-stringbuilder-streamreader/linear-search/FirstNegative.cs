using System;

class FirstNegative
{
    static int FindFirstNegative(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                return arr[i];
            }
        }
        return 0;
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

        int result = FindFirstNegative(arr);

        if (result != 0)
        {
            Console.WriteLine("First negative number is: " + result);
        }
        else
        {
            Console.WriteLine("No negative number found");
        }
    }
}