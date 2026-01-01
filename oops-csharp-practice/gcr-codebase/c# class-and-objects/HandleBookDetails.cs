using System;

//book class to store book information
class Book{
    public string Title; //book title
    public string Author; //book author
    public double Price; //book price

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Author Name: " + Author);
        Console.WriteLine("Book Price: " + Price);
    }
}

class Program
{
    static void Main()
    {
        //Creating Book object
        Book book = new Book();

        //Assigning values
        book.Title = "Clean Code";
        book.Author = "Robert Martin";
        book.Price = 599;

        //Displaying book details
        book.DisplayBookDetails();
    }
}
