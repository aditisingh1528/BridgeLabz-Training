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
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Add Multiple Contacts");
                Console.WriteLine("5. Display Contact");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter a choice: ");
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
                        addressService.DisplayContact();
                        break;

                    case 6:
                        return;
                }
            }
        }
    }
}