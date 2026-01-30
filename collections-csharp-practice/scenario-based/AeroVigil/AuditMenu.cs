using System;
using EventTracker.Tracker;

namespace EventTracker.Menu
{
    // Handles menu operations
    public class AuditMenu
    {
        private readonly AuditScanner scanner = new AuditScanner();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\nEventTracker – Auto Audit System");
                Console.WriteLine("1. Generate Audit Logs");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        scanner.ScanAndLog();
                        break;

                    case 2:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}