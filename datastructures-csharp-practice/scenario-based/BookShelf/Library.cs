using System;

// Manages genres and books
class Library
{
    private GenreNode[] Genres = new GenreNode[10];
    private int Count = 0;

    // Find genre
    private GenreNode FindGenre(string Genre)
    {
        for (int i = 0; i < Count; i++)
        {
            if (Genres[i].Genre.Equals(Genre))
                return Genres[i];
        }
        return null;
    }

    // Create new genre
    private GenreNode CreateGenre(string Genre)
    {
        Genres[Count] = new GenreNode(Genre);
        Count++;
        return Genres[Count - 1];
    }

    // Add book to library
    public void AddBook(string Genre, Book Book)
    {
        GenreNode Node = FindGenre(Genre);
        if (Node == null)
            Node = CreateGenre(Genre);

        Node.BookList.AddBook(Book);
    }

    // Borrow book using ONLY title
    public void BorrowBookByTitle(string Title)
    {
        for (int i = 0; i < Count; i++)
        {
            if (Genres[i].BookList.RemoveBookByTitle(Title))
            {
                Console.WriteLine("Book borrowed successfully");
                return;
            }
        }
        Console.WriteLine("Book not found");
    }

    // Display library
    public void ShowLibrary()
    {
        if (Count == 0)
        {
            Console.WriteLine("Library is empty");
            return;
        }

        for (int i = 0; i < Count; i++)
        {
            Console.WriteLine("Genre: " + Genres[i].Genre);
            Genres[i].BookList.ShowBooks();
            Console.WriteLine();
        }
    }
}