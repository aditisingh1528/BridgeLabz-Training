using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.Json;


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
                throw new DuplicateContactException("Address Book already exists");

            addressBooks[name] = new List<Contact>();
            currentBookName = name;

            Console.WriteLine("Address Book Created");
        }

        public void SelectAddressBook()
        {
            Console.WriteLine("Enter Address Book Name:");
            string name = Console.ReadLine();

            if (!addressBooks.ContainsKey(name))
                throw new AddressBookNotFoundException("Address Book not found");

            currentBookName = name;
        }

        public void AddContact()
        {
            if (currentBookName == null)
                throw new AddressBookNotFoundException("Select Address Book first");

            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

            Contact contact = new Contact
            {
                FirstName = firstName,
                LastName = lastName
            };

            if (addressBooks[currentBookName].Contains(contact))
                throw new DuplicateContactException("Duplicate Contact");

            Console.WriteLine("Enter City:");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State:");
            contact.State = Console.ReadLine();

            addressBooks[currentBookName].Add(contact);
            Console.WriteLine("Contact Added");
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

        // UC-3
        public void EditContact()
        {
            Console.WriteLine("Enter First Name:");
            string name = Console.ReadLine();

            Contact contact = addressBooks[currentBookName]
                .FirstOrDefault(c => c.FirstName == name);

            if (contact == null)
                throw new ContactNotFoundException("Contact not found");

            Console.WriteLine("Enter New City:");
            contact.City = Console.ReadLine();
        }

        //UC-4 
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name:");
            string name = Console.ReadLine();

            Contact contact = addressBooks[currentBookName]
                .FirstOrDefault(c => c.FirstName == name);

            if (contact == null)
                throw new ContactNotFoundException("Contact not found");

            addressBooks[currentBookName].Remove(contact);
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

            if (choice < 1 || choice > 3)
                throw new InvalidInputException("Invalid Sort Option");

            if (choice == 1)
                addressBooks[currentBookName] =
                    addressBooks[currentBookName].OrderBy(c => c.City).ToList();
            else if (choice == 2)
                addressBooks[currentBookName] =
                    addressBooks[currentBookName].OrderBy(c => c.State).ToList();
            else
                addressBooks[currentBookName] =
                    addressBooks[currentBookName].OrderBy(c => c.Zip).ToList();
        }

        public void DisplayContact()
        {
            foreach (var c in addressBooks[currentBookName])
                Console.WriteLine(c);
        }

        //UC-13

        public void WriteAddressBookToFile()
        {
            if (currentBookName == null)
                throw new AddressBookNotFoundException("Select Address Book first");

            string fileName = currentBookName + ".txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Contact c in addressBooks[currentBookName])
                {
                    writer.WriteLine(
                        $"{c.FirstName},{c.LastName},{c.Address},{c.City},{c.State},{c.Zip},{c.PhoneNumber},{c.Email}"
                    );
                }
            }

            Console.WriteLine("Address Book written to file successfully");
        }

        public void ReadAddressBookFromFile()
        {
            if (currentBookName == null)
                throw new AddressBookNotFoundException("Select Address Book first");

            string fileName = currentBookName + ".txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File does not exist");
                return;
            }

            addressBooks[currentBookName].Clear();

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                Contact contact = new Contact
                {
                    FirstName = data[0],
                    LastName = data[1],
                    Address = data[2],
                    City = data[3],
                    State = data[4],
                    Zip = data[5],
                    PhoneNumber = data[6],
                    Email = data[7]
                };

                addressBooks[currentBookName].Add(contact);
            }

            Console.WriteLine("Address Book loaded from file successfully");
        }

        //UC-14
        public void WriteAddressBookToCSV()
        {
            if (currentBookName == null)
                throw new AddressBookNotFoundException("Select Address Book first");

            string fileName = currentBookName + ".csv";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("FirstName,LastName,Address,City,State,Zip,Phone,Email");

                foreach (Contact c in addressBooks[currentBookName])
                {
                    writer.WriteLine(
                        $"{c.FirstName},{c.LastName},{c.Address},{c.City},{c.State},{c.Zip},{c.PhoneNumber},{c.Email}"
                    );
                }
            }

            Console.WriteLine("Address Book written to CSV successfully");
        }


        public void ReadAddressBookFromCSV()
        {
            if (currentBookName == null)
                throw new AddressBookNotFoundException("Select Address Book first");

            string fileName = currentBookName + ".csv";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("CSV file does not exist");
                return;
            }

            addressBooks[currentBookName].Clear();

            string[] lines = File.ReadAllLines(fileName);

            for (int i = 1; i < lines.Length; i++) //skip header
            {
                string[] data = lines[i].Split(',');

                Contact contact = new Contact
                {
                    FirstName = data[0],
                    LastName = data[1],
                    Address = data[2],
                    City = data[3],
                    State = data[4],
                    Zip = data[5],
                    PhoneNumber = data[6],
                    Email = data[7]
                };

                addressBooks[currentBookName].Add(contact);
            }

            Console.WriteLine("Address Book loaded from CSV successfully");
        }

        // UC-15
        public void WriteAddressBookToJSON()
        {
            if (currentBookName == null)
                throw new AddressBookNotFoundException("Select Address Book first");

            string fileName = currentBookName + ".json";

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonData = JsonSerializer.Serialize(
                addressBooks[currentBookName], options);

            File.WriteAllText(fileName, jsonData);

            Console.WriteLine("Address Book written to JSON successfully");
        }

        // UC-15
        public void ReadAddressBookFromJSON()
        {
            if (currentBookName == null)
                throw new AddressBookNotFoundException("Select Address Book first");

            string fileName = currentBookName + ".json";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("JSON file does not exist");
                return;
            }

            string jsonData = File.ReadAllText(fileName);

            addressBooks[currentBookName] =
                JsonSerializer.Deserialize<List<Contact>>(jsonData);

            Console.WriteLine("Address Book loaded from JSON successfully");
        }


    }
}