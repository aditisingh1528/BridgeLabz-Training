using System;

public class BookBuddyApp
{
    // Program execution starts here
    public static void Main(string[] args)
    {
        IBookService bookService = new BookServiceImpl();

        while (true)
        {
            // Menu options
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Sort Books");
            Console.WriteLine("3. Search By Author");
            Console.WriteLine("4. Display All Books");
            Console.WriteLine("5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter book title:");
                    string title = Console.ReadLine();

                    Console.WriteLine("Enter author name:");
                    string author = Console.ReadLine();

                    bookService.AddBook(title, author);
                    break;

                case 2:
                    bookService.SortBooksAlphabetically();
                    break;

                case 3:
                    Console.WriteLine("Enter author name to search:");
                    string searchAuthor = Console.ReadLine();

                    bookService.SearchByAuthor(searchAuthor);
                    break;

                case 4:
                    bookService.DisplayAllBooks();
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
