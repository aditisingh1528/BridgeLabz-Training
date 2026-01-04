using System;

public class Book
{
    public string ISBN;          // public
    protected string title;      // protected
    private string author;       // private

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        this.title = title;
        this.author = author;
    }

    // Getter and Setter for author
    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string author)
    {
        this.author = author;
    }
}

class EBook : Book
{
    public EBook(string isbn, string title, string author)
        : base(isbn, title, author) { }

    public void Display()
    {
        Console.WriteLine($"ISBN: {ISBN}, Title: {title}, Author: {GetAuthor()}");
    }

    static void Main()
    {
        EBook ebook = new EBook("978-123", "Clean Code", "Robert Martin");
        ebook.Display();
    }
}