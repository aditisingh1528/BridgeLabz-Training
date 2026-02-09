namespace AddressBook
{
    interface IAddressBook
    {
        void CreateAddressBook();//UC-6
        void SelectAddressBook(); // UC-6

        void AddContact(); //UC-1,7
        void EditContact(); //UC-3
        void DeleteContact(); //UC-4
        void AddMultipleContacts(); //UC-5
        void SearchPersonByCityOrState(); // UC-8
        void ViewPersonsByCityOrState(); // UC-9
        void CountByCityOrState();// UC-10
        void SortContactsByName();// UC-11
        void SortContactsByCityStateOrZip(); // UC-12
        void DisplayContact();

        //UC-13
         void WriteAddressBookToFile();
        void ReadAddressBookFromFile();
    }
}