using System;

// Linked List to store books
class BookLinkedList
{
    private BookNode Head;

    // Add book at beginning
    public void AddBook(Book Book)
    {
        BookNode Node = new BookNode(Book);
        Node.Next = Head;
        Head = Node;
    }

    // Remove book by TITLE only (for borrowing)
    public bool RemoveBookByTitle(string Title)
    {
        BookNode Current = Head;
        BookNode Previous = null;

        while (Current != null)
        {
            if (Current.Book.GetTitle().Equals(Title))
            {
                if (Previous == null)
                    Head = Current.Next;
                else
                    Previous.Next = Current.Next;

                return true;
            }
            Previous = Current;
            Current = Current.Next;
        }
        return false;
    }

    // Display all books
    public void ShowBooks()
    {
        if (Head == null)
        {
            Console.WriteLine("  No books available");
            return;
        }

        BookNode Temp = Head;
        while (Temp != null)
        {
            Console.WriteLine("  " + Temp.Book.GetTitle() + " by " + Temp.Book.GetAuthor());
            Temp = Temp.Next;
        }
    }
}