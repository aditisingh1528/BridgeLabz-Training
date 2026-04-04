using System;
using EventTracker.Tracker;

namespace EventTracker.Menu
{
    // Handles menu and user interaction
    public class EventMenu
    {
        private readonly AuditScanner scanner = new AuditScanner();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nEventTracker – Auto Audit System");
                Console.WriteLine("1. Generate audit logs");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        scanner.ScanAuditedMethods();
                        break;

                    case 2:
                        Console.WriteLine("Exiting EventTracker...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}