using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    internal class AddressUtilityImpl : IAddressBook
    {
        // UC-6: Dictionary of AddressBook
        private Dictionary<string, List<Contact>> addressBooks =
            new Dictionary<string, List<Contact>>();

        private string currentBookName = null;

        public void CreateAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book already exists");
                return;
            }

            addressBooks[name] = new List<Contact>();
            currentBookName = name;

            Console.WriteLine("Address Book Created!");
        }

        public void SelectAddressBook()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("No Address Books available");
                return;
            }

            Console.WriteLine("Available Address Books:");
            foreach (var name in addressBooks.Keys)
                Console.WriteLine(name);

            Console.WriteLine("Enter Address Book Name:");
            string choice = Console.ReadLine();

            if (!addressBooks.ContainsKey(choice))
            {
                Console.WriteLine("Invalid Address Book");
                return;
            }

            currentBookName = choice;
            Console.WriteLine("Selected Address Book: " + currentBookName);
        }

        // UC-1,7
        public void AddContact()
        {
            if (currentBookName == null)
            {
                Console.WriteLine("Select Address Book first");
                return;
            }

            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            Contact contact = new Contact
            {
                FirstName = firstName,
                LastName = lastName
            };

            // Duplicate check using Collection
            if (addressBooks[currentBookName].Contains(contact))
            {
                Console.WriteLine("Duplicate Contact Found");
                return;
            }

            Console.WriteLine("Enter Address:");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City:");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State:");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip:");
            contact.Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone:");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            contact.Email = Console.ReadLine();

            addressBooks[currentBookName].Add(contact);
            Console.WriteLine("Contact Added Successfully");
        }

        // UC-5
        public void AddMultipleContacts()
        {
            char choice;
            do
            {
                AddContact();
                Console.WriteLine("Add another? (y/n)");
                choice = char.Parse(Console.ReadLine());
            } while (choice == 'y' || choice == 'Y');
        }

        // UC-2
        public void EditContact()
        {
            Console.WriteLine("Enter First Name to Edit:");
            string name = Console.ReadLine();

            var contact = addressBooks[currentBookName]
                .FirstOrDefault(c => c.FirstName.Equals(name));

            if (contact == null)
            {
                Console.WriteLine("Contact Not Found");
                return;
            }

            Console.WriteLine("Enter New City:");
            contact.City = Console.ReadLine();
            Console.WriteLine("Contact Updated");
        }

        // UC-3
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name to Delete:");
            string name = Console.ReadLine();

            var contact = addressBooks[currentBookName]
                .FirstOrDefault(c => c.FirstName.Equals(name));

            if (contact == null)
            {
                Console.WriteLine("Contact Not Found");
                return;
            }

            addressBooks[currentBookName].Remove(contact);
            Console.WriteLine("Contact Deleted");
        }

        // UC-8
        public void SearchPersonByCityOrState()
        {
            Console.WriteLine("1.City 2.State");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value:");
            string value = Console.ReadLine();

            foreach (var book in addressBooks)
            {
                var result = book.Value.Where(c =>
                    (choice == 1 && c.City == value) ||
                    (choice == 2 && c.State == value));

                foreach (var c in result)
                    Console.WriteLine(book.Key + " -> " + c);
            }
        }

        // UC-9
        public void ViewPersonsByCityOrState()
        {
            SearchPersonByCityOrState();
        }

        // UC-10
        public void CountByCityOrState()
        {
            Console.WriteLine("1.City 2.State");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value:");
            string value = Console.ReadLine();

            int count = addressBooks.Values
                .SelectMany(list => list)
                .Count(c => (choice == 1 && c.City == value) ||
                            (choice == 2 && c.State == value));

            Console.WriteLine("Total Count: " + count);
        }

        // UC-11
        public void SortContactsByName()
        {
            addressBooks[currentBookName] =
                addressBooks[currentBookName]
                .OrderBy(c => c.FirstName)
                .ToList();

            Console.WriteLine("Sorted by Name");
        }

        // UC-12
        public void SortContactsByCityStateOrZip()
        {
            Console.WriteLine("1.City 2.State 3.Zip");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                addressBooks[currentBookName] =
                    addressBooks[currentBookName].OrderBy(c => c.City).ToList();
            else if (choice == 2)
                addressBooks[currentBookName] =
                    addressBooks[currentBookName].OrderBy(c => c.State).ToList();
            else
                addressBooks[currentBookName] =
                    addressBooks[currentBookName].OrderBy(c => c.Zip).ToList();

            Console.WriteLine("Sorted Successfully");
        }

        public void DisplayContact()
        {
            foreach (var c in addressBooks[currentBookName])
                Console.WriteLine(c);
        }
    }
}