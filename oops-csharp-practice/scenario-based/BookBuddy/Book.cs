public class Book
{
    // Stores title and author together
    private string titleAuthor;

    // Constructor to initialize book details
    public Book(string title, string author)
    {
        titleAuthor = title + " - " + author;
    }

    // Returns only the title part
    public string GetTitle()
    {
        return titleAuthor.Split(" - ")[0];
    }

    // Returns only the author part
    public string GetAuthor()
    {
        return titleAuthor.Split(" - ")[1];
    }

    // Returns full book info
    public string GetBookInfo()
    {
        return titleAuthor;
    }
}