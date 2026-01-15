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
                Console.WriteLine("\n1. Create Address Book");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Add Multiple Contacts");
                Console.WriteLine("6. Search Person by City or State");
                Console.WriteLine("7. Count by City or State");
                Console.WriteLine("8. Display Contact");
                Console.WriteLine("9. Exit");

                Console.WriteLine("Enter a choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressService.CreateAddressBook();
                        break;
                    case 2:
                        addressService.AddContact();
                        break;
                    case 3:
                        addressService.EditContact();
                        break;
                    case 4:
                        addressService.DeleteContact();
                        break;
                    case 5:
                        addressService.AddMultipleContacts();
                        break;
                    case 6:
                        addressService.SearchPersonByCityOrState();
                        break;
                    case 7:
                        addressService.CountByCityOrState();
                        break;
                    case 8:
                        addressService.DisplayContact();
                        break;
                    case 9:
                        return;
                }
            }
        }
    }
}