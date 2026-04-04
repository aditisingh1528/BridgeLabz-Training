using System;

class Product
{
    public static double Discount = 10;
    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    public Product(string name, double price, int quantity, int id)
    {
        this.ProductName = name;
        this.Price = price;
        this.Quantity = quantity;
        this.ProductID = id;
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    public void Process(object obj)
    {
        if (obj is Product)
        {
            Console.WriteLine(ProductName + " added to cart");
        }
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 60000, 1, 201);

        Product.UpdateDiscount(15);
        p1.Process(p1);
    }
}
