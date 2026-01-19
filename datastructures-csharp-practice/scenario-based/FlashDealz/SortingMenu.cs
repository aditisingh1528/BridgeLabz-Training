using System;

namespace FlashDealzApp
{
    public class SortingMenu
    {
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. View Top Discounted Products");
                Console.WriteLine("2. Exit");
                Console.Write("Enter Choice: ");

                int Choice = int.Parse(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        ShowTopDiscounts();
                        break;

                    case 2:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        private void ShowTopDiscounts()
        {
            Product[] Products =
            {
                new Product(30),
                new Product(85),
                new Product(20),
                new Product(60),
                new Product(95)
            };

            int[] Discounts = new int[Products.Length];
            for (int Index = 0; Index < Products.Length; Index++)
            {
                Discounts[Index] = Products[Index].GetDiscount();
            }

            ISortStrategy SortStrategy = new QuickSort();
            SortStrategy.Sort(Discounts);

            Console.Write("Top Discounts: ");
            SortUtilityImpl.Display(Discounts);
        }
    }
}