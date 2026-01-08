using System;

// Node class for each book (Doubly Linked List)
class BookNode
{
    public int id;
    public string title, author;
    public bool available;
    public BookNode prev, next;
}

// Library class to manage books
class Library
{
    BookNode head, tail;

    // Method to add a new book at the end
    public void AddBook(int id, string t, string a)
    {
        BookNode node = new BookNode
        {
            id = id,
            title = t,
            author = a,
            available = true
        };

        // If library is empty
        if (head == null)
        {
            head = tail = node;
            return;
        }

        // Add book at the end
        tail.next = node;
        node.prev = tail;
        tail = node;
    }

    // Method to count total books
    public int CountBooks()
    {
        int count = 0;
        BookNode temp = head;

        // Traverse the list and count nodes
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        return count;
    }
}
