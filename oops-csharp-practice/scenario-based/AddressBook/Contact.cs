using System;

namespace AddressBook
{
    internal class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phoneNumber;
        private string email;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public override string ToString()
        {
            return "Name : " + firstName + " " + lastName +
                   "\nAddress : " + address +
                   "\nCity : " + city +
                   "\nState : " + state +
                   "\nZip : " + zip +
                   "\nPhone : " + phoneNumber +
                   "\nEmail : " + email;
        }
    }
}