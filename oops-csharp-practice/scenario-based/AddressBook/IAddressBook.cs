namespace AddressBook
{
    interface IAddressBook
    {
        void CreateAddressBook();
        void AddContact();
        void EditContact();
        void DeleteContact();
        void AddMultipleContacts();
        void SearchPersonByCityOrState();
        void CountByCityOrState();
        void SortContactsByName();      // UC-10
        void DisplayContact();
    }
}