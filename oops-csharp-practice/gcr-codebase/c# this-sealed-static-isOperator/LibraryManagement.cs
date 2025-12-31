using System;

class Book
{
    public static string LibraryName = "Central Library";
    public readonly string ISBN;
    public string Title;
    public string Author;

    public Book(string title, string author, string isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine(LibraryName);
    }

    public void Display(object obj)
    {
        if (obj is Book)
        {
            Console.WriteLine(Title + " by " + Author);
        }
    }
}

class Program
{
    static void Main()
    {
        Book.DisplayLibraryName();

        Book book1 = new Book("Clean Code", "Robert Martin", "12345");
        book1.Display(book1);
    }
}
