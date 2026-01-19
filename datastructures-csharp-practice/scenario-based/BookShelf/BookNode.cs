using System;

// Node for linked list of books
class BookNode
{
    public Book Book;
    public BookNode Next;

    public BookNode(Book Book)
    {
        this.Book = Book;
        this.Next = null;
    }
}
