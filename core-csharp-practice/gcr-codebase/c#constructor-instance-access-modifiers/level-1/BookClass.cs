using System;

class Book
{
    private string title;
    private string author;
    private double price;

    // Default constructor
    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        price = 0;
    }

    // Parameterized constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void Display()
    {
        Console.WriteLine($"{title} | {author} | ₹{price}");
    }

    static void Main()
    {
        Book b1 = new Book();
        Book b2 = new Book("Clean Code", "Robert Martin", 500);

        b1.Display();
        b2.Display();
    }
}
