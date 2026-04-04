using System;

class Book
{
    protected string Title;
    protected int Year;

    public Book(string t, int y)
    {
        Title = t;
        Year = y;
    }
}

class Author : Book
{
    private string Name;

    public Author(string t, int y, string n) : base(t, y)
    {
        Name = n;
    }

    public void Display()
    {
        Console.WriteLine($"{Title} ({Year}) by {Name}");
    }
}

class Program
{
    static void Main()
    {
        Author a = new Author("Clean Code", 2008, "Robert Martin");
        a.Display();
    }
}
