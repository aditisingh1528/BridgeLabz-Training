using System;

class CountingSortStudentAges
{
    static void CountingSort(int[] ages)
    {
        int min = 10, max = 18;
        int[] count = new int[max - min + 1];

        // count frequency of each age
        foreach (int age in ages)
            count[age - min]++;

        int index = 0;
        // rebuild sorted array
        for (int i = 0; i < count.Length; i++)
            while (count[i]-- > 0)
                ages[index++] = i + min;
    }

    static void Main()
    {
        int[] ages = { 14, 12, 18, 10, 15 };
        CountingSort(ages);
        Console.WriteLine(string.Join(" ", ages));
    }
}