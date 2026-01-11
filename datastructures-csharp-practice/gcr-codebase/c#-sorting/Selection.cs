using System;

class SelectionSortExamScores
{
    static void SelectionSort(int[] scores)
    {
        for (int i = 0; i < scores.Length - 1; i++)
        {
            int minIndex = i; // assume minimum
            for (int j = i + 1; j < scores.Length; j++)
                if (scores[j] < scores[minIndex])
                    minIndex = j;

            (scores[i], scores[minIndex]) = (scores[minIndex], scores[i]);
        }
    }

    static void Main()
    {
        int[] scores = { 88, 72, 95, 60 };
        SelectionSort(scores);
        Console.WriteLine(string.Join(" ", scores));
    }
}