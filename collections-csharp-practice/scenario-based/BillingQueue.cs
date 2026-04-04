using System;

class BillingQueue
{
    static void Main()
    {
        // Create inventory object to manage items
        Inventory inventory = new Inventory();

        // Create checkout counter and pass inventory to it
        CheckoutCounter counter = new CheckoutCounter(inventory);

        // Main role selection loop
        while (true)
        {
            Console.WriteLine("\nSelect Role");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Cashier");
            Console.WriteLine("3. Exit Application");
            Console.Write("Choice: ");

            int role = int.Parse(Console.ReadLine()); // Read role choice

            // Manager role
            if (role == 1)
            {
                // Manager menu loop
                while (true)
                {
                    Console.WriteLine("\nManager Menu");
                    Console.WriteLine("1. Add Item");
                    Console.WriteLine("2. Remove Item");
                    Console.WriteLine("3. View Inventory");
                    Console.WriteLine("4. Exit Manager Menu");
                    Console.Write("Choice: ");

                    int choice = int.Parse(Console.ReadLine()); // Read manager choice

                    if (choice == 1)
                    {
                        inventory.AddItem(); // Add new item
                    }
                    else if (choice == 2)
                    {
                        inventory.RemoveItem(); // Remove item
                    }
                    else if (choice == 3)
                    {
                        inventory.ViewInventory(); // Display inventory
                    }
                    else if (choice == 4)
                    {
                        break; // Exit manager menu
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }
                }
            }

            // Cashier role
            else if (role == 2)
            {
                // Cashier menu loop
                while (true)
                {
                    Console.WriteLine("\nCashier Menu");
                    Console.WriteLine("1. Add Customer");
                    Console.WriteLine("2. Process Customer");
                    Console.WriteLine("3. Exit Cashier Menu");
                    Console.Write("Choice: ");

                    int choice = int.Parse(Console.ReadLine()); // Read cashier choice

                    if (choice == 1)
                    {
                        counter.AddCustomer(); // Add customer to queue
                    }
                    else if (choice == 2)
                    {
                        counter.ProcessCustomer(); // Process next customer
                    }
                    else if (choice == 3)
                    {
                        break; // Exit cashier menu
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }
                }
            }

            // Exit application
            else if (role == 3)
            {
                Console.WriteLine("Application Closed");
                break; // Exit program
            }

            // Invalid role input
            else
            {
                Console.WriteLine("Invalid role selection");
            }
        }
    }
}