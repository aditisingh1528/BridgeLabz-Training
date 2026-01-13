using System;

public class BookServiceImpl : IBookService
{
    // Array to store books
    private Book[] books;
    private int count;

    // Constructor to initialize array and count
    public BookServiceImpl()
    {
        books = new Book[100];
        count = 0;
    }

    // Adds a new book
    public void AddBook(string title, string author)
    {
        if (count < books.Length)
        {
            books[count] = new Book(title, author);
            count++;
        }
    }

    // Sorts books alphabetically by title
    public void SortBooksAlphabetically()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (books[i].GetTitle()
                    .CompareTo(books[j].GetTitle()) > 0)
                {
                    Book temp = books[i];
                    books[i] = books[j];
                    books[j] = temp;
                }
            }
        }

        Console.WriteLine("Books sorted successfully.");
    }

    // Searches books by author name
    public void SearchByAuthor(string author)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (books[i].GetAuthor()
                .Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(books[i].GetBookInfo());
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No books found for author: " + author);
        }
    }

    // Displays all stored books
    public void DisplayAllBooks()
    {
        if (count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        Console.WriteLine("All Books:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(books[i].GetBookInfo());
        }
    }
}