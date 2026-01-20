using System;

namespace AadharNumberSort
{
    public class AadharService : IAadharService
    {
        private Aadhar[] aadhars;

        public AadharService(Aadhar[] aadhars)
        {
            this.aadhars = aadhars;
        }

        public void Sort()
        {
            AadharUtilityImpl.RadixSort(aadhars);
            Console.WriteLine("Sorted Successfully");
        }

        public int BinarySearch(long target)
        {
            return AadharUtilityImpl.BinarySearch(aadhars, target);
        }

        public void Display()
        {
            for (int i = 0; i < aadhars.Length; i++)
                Console.WriteLine(aadhars[i].GetNumber());
        }
    }
}