using System;

namespace FlashDealzApp
{
    public static class SortUtilityImpl
    {
        public static void Display(int[] Data)
        {
            for (int Index = 0; Index < Data.Length; Index++)
            {
                Console.Write(Data[Index] + " ");
            }
            Console.WriteLine();
        }
    }
}