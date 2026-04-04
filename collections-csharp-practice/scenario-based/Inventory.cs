using System;
using System.Collections.Generic;

public class Inventory
{
    // Stores item name and its price
    private Dictionary<string, int> priceMap = new Dictionary<string, int>();

    // Stores item name and its available stock
    private Dictionary<string, int> stockMap = new Dictionary<string, int>();

    // Manager adds a new item to inventory
    public void AddItem()
    {
        Console.Write("Item name: ");
        string item = Console.ReadLine(); // Read item name

        Console.Write("Price: ");
        int price = int.Parse(Console.ReadLine()); // Read item price

        Console.Write("Stock: ");
        int stock = int.Parse(Console.ReadLine()); // Read item stock

        // Store price and stock in dictionaries
        priceMap[item] = price;
        stockMap[item] = stock;

        Console.WriteLine("Item added to inventory");
    }

    // Manager removes an item from inventory
    public void RemoveItem()
    {
        Console.Write("Enter item name to delete: ");
        string item = Console.ReadLine(); // Read item name

        // Check if item exists
        if (priceMap.ContainsKey(item))
        {
            priceMap.Remove(item); // Remove price entry
            stockMap.Remove(item); // Remove stock entry
            Console.WriteLine("Item removed");
        }
        else
        {
            Console.WriteLine("Item not found");
        }
    }

    // Manager views all items in inventory
    public void ViewInventory()
    {
        Console.WriteLine("\nInventory:");
        foreach (var item in priceMap.Keys)
        {
            // Display item name, price, and stock
            Console.WriteLine(item + " | Price: " + priceMap[item] +
                               " | Stock: " + stockMap[item]);
        }
    }

    // Checks if item is available for cashier
    public bool IsItemAvailable(string item)
    {
        return stockMap.ContainsKey(item) && stockMap[item] > 0;
    }

    // Returns price of the item
    public int GetPrice(string item)
    {
        return priceMap[item];
    }

    // Reduces stock after purchase
    public void UpdateStock(string item)
    {
        stockMap[item] = stockMap[item] - 1;
    }
}