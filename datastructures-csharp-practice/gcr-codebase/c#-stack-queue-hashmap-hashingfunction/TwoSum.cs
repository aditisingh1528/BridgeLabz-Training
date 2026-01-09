using System;
using System.Collections.Generic;

class TwoSum
{
    // Finds indices of two elements adding to target
    static int[] TwoSumIndices(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>(); // Value → index

        for (int i = 0; i < nums.Length; i++)
        {
            int remaining = target - nums[i];

            if (map.ContainsKey(remaining))
                return new int[] { map[remaining], i };

            if (!map.ContainsKey(nums[i]))
                map.Add(nums[i], i);
        }

        return new int[] { -1, -1 };
    }
}