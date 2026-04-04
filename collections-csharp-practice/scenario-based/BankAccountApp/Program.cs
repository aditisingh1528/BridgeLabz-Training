using BankAccountApp.Menu;

namespace BankAccountApp
{
    class Program
    {
        static void Main()
        {
            BankMenu menu = new BankMenu();
            menu.ShowMenu();
        }
    }
}