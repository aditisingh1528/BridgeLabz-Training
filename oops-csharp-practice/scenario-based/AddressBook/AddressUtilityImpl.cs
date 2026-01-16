using System;

namespace AddressBook
{
    internal class AddressUtilityImpl : IAddressBook
    {
        private string[] addressBookNames = new string[5];
        private Contact[,] addressBooks = new Contact[5, 10];
        private int[] contactCount = new int[5];

        private int bookCount = 0;
        private int currentBookIndex = -1;

        // UC-5
        public void CreateAddressBook()
        {
            if (bookCount >= addressBookNames.Length)
            {
                Console.WriteLine("Maximum Address Books reached");
                return;
            }

            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            for (int i = 0; i < bookCount; i++)
            {
                if (addressBookNames[i].Equals(name))
                {
                    Console.WriteLine("Address Book already exists");
                    return;
                }
            }

            addressBookNames[bookCount] = name;
            contactCount[bookCount] = 0;
            currentBookIndex = bookCount;
            bookCount++;

            Console.WriteLine("Address Book Created and Selected");
        }

        // UC-1 + UC-6 (Duplicate Check)
        public void AddContact()
        {
            if (currentBookIndex == -1)
            {
                Console.WriteLine("Please create an Address Book first");
                return;
            }

            if (contactCount[currentBookIndex] >= 10)
            {
                Console.WriteLine("Address Book is full");
                return;
            }

            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();
			
			//UC-6
            for (int i = 0; i < contactCount[currentBookIndex]; i++)
            {
                if (addressBooks[currentBookIndex, i].FirstName.Equals(firstName)
                    && addressBooks[currentBookIndex, i].LastName.Equals(lastName))
                {
                    Console.WriteLine("Duplicate contact found. Contact not added.");
                    return;
                }
            }

            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = lastName;

            Console.WriteLine("Enter Address:");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter State:");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter Zip:");
            contact.Zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            contact.Email = Console.ReadLine();

            addressBooks[currentBookIndex, contactCount[currentBookIndex]] = contact;
            contactCount[currentBookIndex]++;

            Console.WriteLine("Contact Added Successfully");
        }

        // UC-4
        public void AddMultipleContacts()
        {
            char choice;
            do
            {
                AddContact();
                Console.WriteLine("Do you want to add another contact? (y/n)");
                choice = char.Parse(Console.ReadLine());
            }
            while (choice == 'y' || choice == 'Y');
        }
		
		public void SearchPersonByCityOrState()
        {
            Console.WriteLine("Search by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");

            Console.WriteLine("Enter a choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value to search:");
            string value = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < bookCount; i++)
            {
                for (int j = 0; j < contactCount[i]; j++)
                {
                    Contact contact = addressBooks[i, j];

                    if ((choice == 1 && contact.City.Equals(value)) ||
                        (choice == 2 && contact.State.Equals(value)))
                    {
                        Console.WriteLine("\nAddress Book: " + addressBookNames[i]);
                        Console.WriteLine(contact);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No contacts found");
            }
        }
		
		public void CountByCityOrState()
        {
            Console.WriteLine("Count by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");

            Console.WriteLine("Enter a choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value:");
            string value = Console.ReadLine();

            int countResult = 0;

            for (int i = 0; i < bookCount; i++)
            {
                for (int j = 0; j < contactCount[i]; j++)
                {
                    Contact contact = addressBooks[i, j];

                    if ((choice == 1 && contact.City.Equals(value)) ||
                        (choice == 2 && contact.State.Equals(value)))
                    {
                        countResult++;
                    }
                }
            }

            Console.WriteLine("Total contacts found: " + countResult);
        }
		
		//UC-10: Sort Contacts Alphabetically
		public void SortContactsByName()
        {
            if (currentBookIndex == -1)
            {
                Console.WriteLine("No Address Book selected");
                return;
            }

            int n = contactCount[currentBookIndex];

            if (n <= 1)
            {
                Console.WriteLine("Not enough contacts to sort");
                return;
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    string name1 = addressBooks[currentBookIndex, j].FirstName;
                    string name2 = addressBooks[currentBookIndex, j + 1].FirstName;

                    if (string.Compare(name1, name2) > 0)
                    {
                        Contact temp = addressBooks[currentBookIndex, j];
                        addressBooks[currentBookIndex, j] = addressBooks[currentBookIndex, j + 1];
                        addressBooks[currentBookIndex, j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Contacts sorted alphabetically by name");
        }
		
		// UC-11: Sort by City, State or Zip
        public void SortContactsByCityStateOrZip()
        {
            if (currentBookIndex == -1)
            {
                Console.WriteLine("No Address Book selected");
                return;
            }

            Console.WriteLine("Sort by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            Console.WriteLine("3. Zip");

            Console.WriteLine("Enter a choice: ");
            int choice = int.Parse(Console.ReadLine());

            int n = contactCount[currentBookIndex];

            if (n <= 1)
            {
                Console.WriteLine("Not enough contacts to sort");
                return;
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    string value1 = "";
                    string value2 = "";

                    if (choice == 1)
                    {
                        value1 = addressBooks[currentBookIndex, j].City;
                        value2 = addressBooks[currentBookIndex, j + 1].City;
                    }
                    else if (choice == 2)
                    {
                        value1 = addressBooks[currentBookIndex, j].State;
                        value2 = addressBooks[currentBookIndex, j + 1].State;
                    }
                    else if (choice == 3)
                    {
                        value1 = addressBooks[currentBookIndex, j].Zip;
                        value2 = addressBooks[currentBookIndex, j + 1].Zip;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                        return;
                    }

                    if (string.Compare(value1, value2) > 0)
                    {
                        Contact temp = addressBooks[currentBookIndex, j];
                        addressBooks[currentBookIndex, j] = addressBooks[currentBookIndex, j + 1];
                        addressBooks[currentBookIndex, j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Contacts sorted successfully");
        }
		
		
        // UC-2
        public void EditContact()
        {
            if (currentBookIndex == -1)
            {
                Console.WriteLine("No Address Book selected");
                return;
            }

            Console.WriteLine("Enter First Name to Edit:");
            string name = Console.ReadLine();

            for (int i = 0; i < contactCount[currentBookIndex]; i++)
            {
                if (addressBooks[currentBookIndex, i].FirstName.Equals(name))
                {
                    Console.WriteLine("Enter New City:");
                    addressBooks[currentBookIndex, i].City = Console.ReadLine();
                    Console.WriteLine("Contact Updated Successfully");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found");
        }

        // UC-3
        public void DeleteContact()
        {
            if (currentBookIndex == -1)
            {
                Console.WriteLine("No Address Book selected");
                return;
            }

            Console.WriteLine("Enter First Name to Delete:");
            string name = Console.ReadLine();

            for (int i = 0; i < contactCount[currentBookIndex]; i++)
            {
                if (addressBooks[currentBookIndex, i].FirstName.Equals(name))
                {
                    for (int j = i; j < contactCount[currentBookIndex] - 1; j++)
                    {
                        addressBooks[currentBookIndex, j] =
                            addressBooks[currentBookIndex, j + 1];
                    }

                    contactCount[currentBookIndex]--;
                    Console.WriteLine("Contact Deleted Successfully");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found");
        }

        public void DisplayContact()
        {
            if (currentBookIndex == -1)
            {
                Console.WriteLine("No Address Book selected");
                return;
            }

            if (contactCount[currentBookIndex] == 0)
            {
                Console.WriteLine("No contacts to display");
                return;
            }

            for (int i = 0; i < contactCount[currentBookIndex]; i++)
            {
                Console.WriteLine("\n--- Contact ---");
                Console.WriteLine(addressBooks[currentBookIndex, i]);
            }
        }
    }
}