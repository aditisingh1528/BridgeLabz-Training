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
                }
            }
        }

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
                Console.WriteLine("11. Write Address Book to File");
                Console.WriteLine("12. Read Address Book from File");
                Console.WriteLine("13. Write Address Book to CSV");
                Console.WriteLine("14. Read Address Book from CSV");
                Console.WriteLine("15. Write Address Book to JSON");
                Console.WriteLine("16. Read Address Book from JSON");
                Console.WriteLine("17. Back");




                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: addressService.AddContact();
                        break;
                    case 2: addressService.EditContact();
                        break;
                    case 3: addressService.DeleteContact();
                        break;
                    case 4: addressService.AddMultipleContacts();
                        break;
                    case 5: addressService.SearchPersonByCityOrState();
                        break;
                    case 6: addressService.ViewPersonsByCityOrState();
                        break;
                    case 7: addressService.CountByCityOrState();
                        break;
                    case 8: addressService.SortContactsByName();
                        break;
                    case 9: addressService.SortContactsByCityStateOrZip();
                        break;
                    case 10: addressService.DisplayContact();
                        break;
                    case 11: addressService.WriteAddressBookToFile(); 
                        break;
                    case 12: addressService.ReadAddressBookFromFile(); 
                        break;
                    case 13: addressService.WriteAddressBookToCSV(); 
                        break;
                    case 14: addressService.ReadAddressBookFromCSV(); 
                        break;
                    case 15: addressService.WriteAddressBookToJSON(); 
                        break;
                    case 16: addressService.ReadAddressBookFromJSON(); 
                        break;
                    case 17: 
                        return;

                }
            }
        }
    }
}