using System;

class InsertionSortEmployeeIDs
{
    static void InsertionSort(int[] ids)
    {
        for (int i = 1; i < ids.Length; i++)
        {
            int key = ids[i]; // current element
            int j = i - 1;

            // shift larger elements to the right
            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }
            // insert at correct position
            ids[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] ids = { 104, 101, 109, 102 };
        InsertionSort(ids);
        Console.WriteLine(string.Join(" ", ids));
    }
}