using System;

namespace AddressBook
{
    internal class AddressUtilityImpl : IAddressBook
    {
        private Contact contact = new Contact();

        // UC-1: Create Contact
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

        public void DisplayContact()
        {
            Console.WriteLine("\n--- Contact Details ---");
            Console.WriteLine(contact);
        }
    }
}