using System;
using HealthCheckPro.Scanner;
using HealthCheckPro.Documentation;

namespace HealthCheckPro
{
    class Program
    {
        static void Main()
        {
            // Create objects for scanning and documentation
            ApiScanner scanner = new ApiScanner();
            ApiDocGenerator docGenerator = new ApiDocGenerator();

            while (true)
            {
                // Menu
                Console.WriteLine("\nHealthCheckPro – API Metadata Validator");
                Console.WriteLine("1. Scan APIs for missing annotations");
                Console.WriteLine("2. Generate API Documentation");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        scanner.ScanControllers();
                        break;

                    case 2:
                        docGenerator.GenerateDocs();
                        break;

                    case 3:
                        Console.WriteLine("Exiting application...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}