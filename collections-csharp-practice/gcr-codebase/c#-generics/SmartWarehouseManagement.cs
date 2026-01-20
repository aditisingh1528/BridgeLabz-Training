using System;
using System.Collections.Generic;

abstract class WarehouseItem
{
    public string Name { get; set; }
    public abstract void Display();
}

// Derived classes
class Electronics : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine($"Electronics Item: {Name}");
    }
}

class Groceries : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine($"Grocery Item: {Name}");
    }
}

class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        foreach (var item in items)
            item.Display();
    }
}

class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics { Name = "Laptop" });
        electronicsStorage.DisplayItems();
    }
}
