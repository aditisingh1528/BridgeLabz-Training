using System;

namespace FlashDealzApp
{
    public class Product
    {
        private int Discount;

        public Product(int Discount)
        {
            this.Discount = Discount;
        }

        public int GetDiscount()
        {
            return Discount;
        }

        public void SetDiscount(int Discount)
        {
            this.Discount = Discount;
        }
    }
}