namespace AddressBook
{
    interface IAddressBook
    {
        void CreateAddressBook();
        void AddContact();
        void EditContact();
        void DeleteContact();
        void AddMultipleContacts();
        void SearchPersonByCityOrState();   // UC-8
        void DisplayContact();
    }
}
