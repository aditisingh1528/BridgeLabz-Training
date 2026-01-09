using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    // Returns max in each window
    static int[] MaxSlidingWindow(int[] arr, int k)
    {
        int n = arr.Length;
        int[] ans = new int[n - k + 1];
        LinkedList<int> deque = new LinkedList<int>(); // Stores indices
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            if (deque.Count > 0 && deque.First.Value <= i - k)
                deque.RemoveFirst(); // Remove out of window

            while (deque.Count > 0 && arr[deque.Last.Value] <= arr[i])
                deque.RemoveLast(); // Remove smaller values

            deque.AddLast(i);

            if (i >= k - 1)
                ans[index++] = arr[deque.First.Value]; // Window max
        }

        return ans;
    }
}