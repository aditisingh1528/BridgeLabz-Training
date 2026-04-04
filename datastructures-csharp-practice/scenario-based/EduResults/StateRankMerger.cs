using System;

public class StateRankMerger
{
    // Merge Sort for final state ranking
    public void MergeSort(Student[] Arr, int Left, int Right)
    {
        if (Left < Right)
        {
            int Mid = (Left + Right) / 2;

            MergeSort(Arr, Left, Mid);
            MergeSort(Arr, Mid + 1, Right);

            Merge(Arr, Left, Mid, Right);
        }
    }

    // Merge two sorted halves
    private void Merge(Student[] Arr, int Left, int Mid, int Right)
    {
        int N1 = Mid - Left + 1;
        int N2 = Right - Mid;

        Student[] LeftArr = new Student[N1];
        Student[] RightArr = new Student[N2];

        for (int I = 0; I < N1; I++)
            LeftArr[I] = Arr[Left + I];

        for (int J = 0; J < N2; J++)
            RightArr[J] = Arr[Mid + 1 + J];

        int IIndex = 0, JIndex = 0, K = Left;

        while (IIndex < N1 && JIndex < N2)
        {
            if (LeftArr[IIndex].GetMarks() <= RightArr[JIndex].GetMarks())
            {
                Arr[K] = LeftArr[IIndex];
                IIndex++;
            }
            else
            {
                Arr[K] = RightArr[JIndex];
                JIndex++;
            }
            K++;
        }

        // Copy remaining elements
        while (IIndex < N1)
            Arr[K++] = LeftArr[IIndex++];

        while (JIndex < N2)
            Arr[K++] = RightArr[JIndex++];
    }
}