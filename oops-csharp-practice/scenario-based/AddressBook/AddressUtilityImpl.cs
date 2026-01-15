using System;

namespace AddressBook
{
    internal class AddressUtilityImpl : IAddressBook
    {
        private Contact[] contacts = new Contact[10];
        private int count = 0;

        // UC-1: Add single contact
        public void AddContact()
        {
            if (count >= contacts.Length)
            {
                Console.WriteLine("Address Book is full");
                return;
            }

            Contact contact = new Contact();

            Console.WriteLine("Enter First Name:");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            contact.LastName = Console.ReadLine();

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

            contacts[count] = contact;
            count++;

            Console.WriteLine("Contact Added Successfully");
        }

        // UC-4: Add multiple contacts
        public void AddMultipleContacts()
        {
            char choice;
            do
            {
                AddContact();

                Console.WriteLine("Do you want to add another contact? (y/n)");
                choice = char.Parse(Console.ReadLine());

            } while (choice == 'y' || choice == 'Y');
        }

        // UC-2: Edit contact
        public void EditContact()
        {
            Console.WriteLine("Enter First Name to Edit:");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
                    Console.WriteLine("Enter New Address:");
                    contacts[i].Address = Console.ReadLine();

                    Console.WriteLine("Enter New City:");
                    contacts[i].City = Console.ReadLine();

                    Console.WriteLine("Enter New State:");
                    contacts[i].State = Console.ReadLine();

                    Console.WriteLine("Enter New Zip:");
                    contacts[i].Zip = Console.ReadLine();

                    Console.WriteLine("Enter New Phone Number:");
                    contacts[i].PhoneNumber = Console.ReadLine();

                    Console.WriteLine("Enter New Email:");
                    contacts[i].Email = Console.ReadLine();

                    Console.WriteLine("Contact Updated Successfully");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found");
        }

        // UC-3: Delete contact
        public void DeleteContact()
        {
            Console.WriteLine("Enter First Name to Delete:");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].FirstName.Equals(name))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }

                    contacts[count - 1] = null;
                    count--;

                    Console.WriteLine("Contact Deleted Successfully");
                    return;
                }
            }

            Console.WriteLine("Contact Not Found");
        }

        public void DisplayContact()
        {
            if (count == 0)
            {
                Console.WriteLine("No contacts to display");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\n--- Contact ---");
                Console.WriteLine(contacts[i]);
            }
        }
    }
}