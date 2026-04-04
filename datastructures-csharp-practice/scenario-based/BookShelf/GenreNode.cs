using System;

// Represents a Genre containing a list of books
class GenreNode
{
    public string Genre;
    public BookLinkedList BookList;

    public GenreNode(string Genre)
    {
        this.Genre = Genre;
        BookList = new BookLinkedList();
    }
}