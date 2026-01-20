using System;

namespace AadharNumberSort
{
    public class Aadhar
    {
        private long number;

        public Aadhar(long number)
        {
            this.number = number;
        }

        public long GetNumber()
        {
            return number;
        }

        public void SetNumber(long number)
        {
            this.number = number;
        }
    }
}