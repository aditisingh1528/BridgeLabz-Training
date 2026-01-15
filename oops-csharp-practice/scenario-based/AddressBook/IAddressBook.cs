namespace AddressBook
{
    interface IAddressBook
    {
        void CreateAddressBook();   // UC-5
        void AddContact();
        void EditContact();
        void DeleteContact();
        void AddMultipleContacts();
        void DisplayContact();
    }
}