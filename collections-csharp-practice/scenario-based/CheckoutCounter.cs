using System;
using System.Collections.Generic;

public class CheckoutCounter
{
    // Queue to store customers in FIFO order
    private Queue<Customer> queue = new Queue<Customer>();

    // Inventory reference to check price and stock
    private Inventory inventory;

    // Constructor to initialize inventory
    public CheckoutCounter(Inventory inventory)
    {
        this.inventory = inventory;
    }

    // Adds a customer to the billing queue
    public void AddCustomer()
    {
        Console.Write("Customer ID: ");
        int id = int.Parse(Console.ReadLine()); // Read customer ID

        Console.Write("Number of items: ");
        int n = int.Parse(Console.ReadLine()); // Read number of items

        // Array to store item names
        string[] items = new string[n];

        // Read each item name
        for (int i = 0; i < n; i++)
        {
            Console.Write("Item name: ");
            items[i] = Console.ReadLine();
        }

        // Add customer to queue
        queue.Enqueue(new Customer(id, items));
        Console.WriteLine("Customer added to queue");
    }

    // Processes the next customer in queue
    public void ProcessCustomer()
    {
        // Check if queue is empty
        if (queue.Count == 0)
        {
            Console.WriteLine("No customers in queue");
            return;
        }

        // Remove customer from queue
        Customer customer = queue.Dequeue();
        int totalBill = 0; // Total bill amount

        Console.WriteLine("\nBilling Details");
        Console.WriteLine("Customer ID: " + customer.GetCustomerId());
        Console.WriteLine("Items Purchased:");

        // Process each item
        foreach (string item in customer.GetItems())
        {
            if (inventory.IsItemAvailable(item)) // Check stock
            {
                int price = inventory.GetPrice(item); // Get item price
                totalBill += price;                   // Add to total bill
                inventory.UpdateStock(item);          // Reduce stock

                Console.WriteLine("- " + item + " : ₹" + price);
            }
            else
            {
                Console.WriteLine("- " + item + " : Not Available");
            }
        }

        Console.WriteLine("---------------------------");
        Console.WriteLine("Total Bill Amount: ₹" + totalBill);
    }
}