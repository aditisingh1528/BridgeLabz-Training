using System;

class SortingAlgorithms
{
    // Bubble Sort – Sort Student Marks
    static void BubbleSort(int[] marks)
    {
        for (int i = 0; i < marks.Length - 1; i++)
        {
            for (int j = 0; j < marks.Length - i - 1; j++)
            {
                // compare adjacent elements
                if (marks[j] > marks[j + 1])
                {
                    // swap if order is wrong
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }
    }
}