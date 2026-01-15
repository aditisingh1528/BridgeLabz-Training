using System;

namespace AddressBook
{
    internal class AddressUtilityImpl : IAddressBook
    {
        private Contact contact = new Contact();

        // UC-1: Add Contact
        public void AddContact()
        {
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

            Console.WriteLine("Contact Added Successfully");
        }

        // UC-2: Edit Contact using First Name
        public void EditContact()
        {
            Console.WriteLine("Enter First Name to Edit:");
            string name = Console.ReadLine();

            if (contact.FirstName != null && contact.FirstName.Equals(name))
            {
                Console.WriteLine("Enter New Address:");
                contact.Address = Console.ReadLine();

                Console.WriteLine("Enter New City:");
                contact.City = Console.ReadLine();

                Console.WriteLine("Enter New State:");
                contact.State = Console.ReadLine();

                Console.WriteLine("Enter New Zip:");
                contact.Zip = Console.ReadLine();

                Console.WriteLine("Enter New Phone Number:");
                contact.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter New Email:");
                contact.Email = Console.ReadLine();

                Console.WriteLine("Contact Updated Successfully");
            }
            else
            {
                Console.WriteLine("Contact Not Found");
            }
        }

        public void DisplayContact()
        {
            Console.WriteLine("\n--- Contact Details ---");
            Console.WriteLine(contact);
        }
    }
}