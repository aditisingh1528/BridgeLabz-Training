using System;

namespace AddressBook
{
    sealed class AddressBookMenu
    {
        private IAddressBook addressService;

        public void Menu()
        {
            addressService = new AddressUtilityImpl();

            while (true)
            {
                Console.WriteLine("\n1. Add Contact (UC-1)");
                Console.WriteLine("2. Display Contact");
                Console.WriteLine("3. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressService.AddContact();
                        break;

                    case 2:
                        addressService.DisplayContact();
                        break;

                    case 3:
                        return;
                }
            }
        }
    }
}