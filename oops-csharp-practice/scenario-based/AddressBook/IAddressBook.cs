namespace AddressBook
{
    interface IAddressBook
    {
        void AddContact();
        void EditContact();
        void DeleteContact();
        void AddMultipleContacts();//UC- 4
        void DisplayContact();
    }
}