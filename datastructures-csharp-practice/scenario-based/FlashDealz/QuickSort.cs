namespace FlashDealzApp
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(int[] Data)
        {
            QuickSortAlgorithm(Data, 0, Data.Length - 1);
        }

        private void QuickSortAlgorithm(int[] Array, int Low, int High)
        {
            if (Low < High)
            {
                int PivotIndex = Partition(Array, Low, High);
                QuickSortAlgorithm(Array, Low, PivotIndex - 1);
                QuickSortAlgorithm(Array, PivotIndex + 1, High);
            }
        }

        private int Partition(int[] Array, int Low, int High)
        {
            int Pivot = Array[High];
            int Index = Low - 1;

            for (int J = Low; J < High; J++)
            {
                if (Array[J] > Pivot)
                {
                    Index++;
                    int Temp = Array[Index];
                    Array[Index] = Array[J];
                    Array[J] = Temp;
                }
            }

            int T = Array[Index + 1];
            Array[Index + 1] = Array[High];
            Array[High] = T;

            return Index + 1;
        }
    }
}