using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    // Finds longest consecutive sequence length
    static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
            set.Add(nums[i]); // Store elements

        int longest = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!set.Contains(nums[i] - 1)) // Start of sequence
            {
                int current = nums[i];
                int count = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    count++;
                }

                if (count > longest)
                    longest = count;
            }
        }

        return longest;
    }
}