using System;
// Represents a Book entity
class Book
{
    private string Title;
    private string Author;

    public Book(string Title, string Author)
    {
        this.Title = Title;
        this.Author = Author;
    }

    public string GetTitle()
    {
        return Title;
    }

    public string GetAuthor()
    {
        return Author;
    }
}