using System;

class Product
{
    //Instance variables
    string productName;
    double price;

    //Class variable
    static int totalProducts = 0;

    //Constructor
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    //Instance method
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product: {productName}, Price: {price}");
    }

    //Class method
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products: {totalProducts}");
    }

    static void Main()
    {
        Product p1 = new Product("Laptop", 50000);
        Product p2 = new Product("Mouse", 800);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();

        Product.DisplayTotalProducts();
    }
}
