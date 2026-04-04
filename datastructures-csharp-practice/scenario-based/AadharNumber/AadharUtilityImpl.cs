using System;

namespace AadharNumberSort
{
    public static class AadharUtilityImpl
    {
        public static void RadixSort(Aadhar[] arr)
        {
            long max = arr[0].GetNumber();
            for (int i = 1; i < arr.Length; i++)
                if (arr[i].GetNumber() > max)
                    max = arr[i].GetNumber();

            for (long exp = 1; max / exp > 0; exp *= 10)
                CountSort(arr, exp);
        }

        private static void CountSort(Aadhar[] arr, long exp)
        {
            int n = arr.Length;
            Aadhar[] output = new Aadhar[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
                count[(arr[i].GetNumber() / exp) % 10]++;

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                int idx = (int)((arr[i].GetNumber() / exp) % 10);
                output[count[idx] - 1] = arr[i];
                count[idx]--;
            }

            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public static int BinarySearch(Aadhar[] arr, long target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid].GetNumber() == target)
                    return mid;

                if (arr[mid].GetNumber() < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}