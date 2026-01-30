using EventTracker.Menu;

namespace EventTracker
{
    class Program
    {
        static void Main()
        {
            // Start menu
            AuditMenu menu = new AuditMenu();
            menu.ShowMenu();
        }
    }
}