using System;

public class Book{

    // Book attributes
    private string title;
    private string author;
    private double price;
    private bool available;

    // Constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.available = true; // book is available initially
    }

    // Method to borrow a book
    public void BorrowBook()
    {
        if (available)
        {
            available = false;
            Console.WriteLine("Book borrowed successfully");
        }
        else
        {
            Console.WriteLine("Book not available");
        }
    }

    static void Main()
    {
        Book b = new Book("Harry Potter", "JK Rowling", 400);
        b.BorrowBook();
        b.BorrowBook();
    }
}