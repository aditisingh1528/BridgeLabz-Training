using System;

namespace AddressBook
{
    // 1. Address Book not found
    class AddressBookNotFoundException : Exception
    {
        public AddressBookNotFoundException(string message) : base(message) { }
    }

    // 2. Duplicate Contact
    class DuplicateContactException : Exception
    {
        public DuplicateContactException(string message) : base(message) { }
    }

    // 3. Contact not found
    class ContactNotFoundException : Exception
    {
        public ContactNotFoundException(string message) : base(message) { }
    }

    // 4. Invalid input
    class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message) { }
    }
}