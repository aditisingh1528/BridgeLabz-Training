using System;

namespace AadharNumberSort
{
    public class AadharMenu
    {
        private IAadharService service;

        public AadharMenu(IAadharService service)
        {
            this.service = service;
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n1.Sort\n2.Search\n3.Display\n4.Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.Sort();
                        break;

                    case 2:
                        Console.Write("Enter Aadhar Number: ");
                        long key = long.Parse(Console.ReadLine());
                        int index = service.BinarySearch(key);
                        Console.WriteLine(index == -1 ? "Not Found" : "Found at index " + index);
                        break;

                    case 3:
                        service.Display();
                        break;

                    case 4:
                        return;
                }
            }
        }
    }
}