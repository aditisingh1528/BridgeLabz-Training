using System;

namespace AddressBook
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            AddressBookMenu menu = new AddressBookMenu();
            menu.Menu();
        }
    }
}  