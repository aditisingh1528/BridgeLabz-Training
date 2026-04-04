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
                Console.WriteLine("\n--- Address Book System ---");
                Console.WriteLine("1. Create Address Book");
                Console.WriteLine("2. Select Existing Address Book");
                Console.WriteLine("3. Exit");

                Console.WriteLine("Enter choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressService.CreateAddressBook();
                        break;

                    case 2:
                        addressService.SelectAddressBook();
                        AddressBookOperationsMenu();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        // 🔽 Address Book level menu
        private void AddressBookOperationsMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- Address Book Menu ---");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Add Multiple Contacts");
                Console.WriteLine("5. Search Person by City or State");
                Console.WriteLine("6. View Persons by City or State");
                Console.WriteLine("7. Count by City or State");
                Console.WriteLine("8. Sort Contacts by Name");
                Console.WriteLine("9. Sort Contacts by City / State / Zip");
                Console.WriteLine("10. Display Contacts");
                Console.WriteLine("11. Back to Address Book Selection");

                Console.WriteLine("Enter choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        addressService.AddContact();
                        break;
                    case 2:
                        addressService.EditContact();
                        break;
                    case 3:
                        addressService.DeleteContact();
                        break;
                    case 4:
                        addressService.AddMultipleContacts();
                        break;
                    case 5:
                        addressService.SearchPersonByCityOrState();
                        break;
                    case 6:
                        addressService.ViewPersonsByCityOrState();
                        break;
                    case 7:
                        addressService.CountByCityOrState();
                        break;
                    case 8:
                        addressService.SortContactsByName();
                        break;
                    case 9:
                        addressService.SortContactsByCityStateOrZip();
                        break;
                    case 10:
                        addressService.DisplayContact();
                        break;
                    case 11:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}