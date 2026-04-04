using System;

namespace AadharNumberSort
{
    public interface IAadharService
    {
        void Sort();
        int BinarySearch(long target);
        void Display();
    }
}