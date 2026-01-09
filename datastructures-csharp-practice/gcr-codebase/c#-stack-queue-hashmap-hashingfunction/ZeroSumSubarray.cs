using System;
using System.Collections.Generic;

class FindAllSubarraysWithZeroSum
{
    // Checks if zero sum subarray exists
    static void CheckZeroSum(int[] arr)
    {
        HashSet<int> set = new HashSet<int>(); // Prefix sums
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i];

            if (sum == 0 || set.Contains(sum)) // Zero sum condition
            {
                Console.WriteLine("Zero sum subarray exists");
                return;
            }

            set.Add(sum);
        }

        Console.WriteLine("No zero sum subarray exists");
    }
}
