using System;

// Entry point
class BookShelvesMain
{
    static void Main()
    {
        Library Library = new Library();

        while (true)
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Show Library");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int Choice = Convert.ToInt32(Console.ReadLine());

            if (Choice == 1)
            {
                Console.Write("Enter Genre: ");
                string Genre = Console.ReadLine();

                Console.Write("Enter Book Title: ");
                string Title = Console.ReadLine();

                Console.Write("Enter Author: ");
                string Author = Console.ReadLine();

                Library.AddBook(Genre, new Book(Title, Author));
                Console.WriteLine("Book added successfully\n");
            }
            else if (Choice == 2)
            {
                Console.Write("Enter Book Title to Borrow: ");
                string Title = Console.ReadLine();

                Library.BorrowBookByTitle(Title);
                Console.WriteLine();
            }
            else if (Choice == 3)
            {
                Library.ShowLibrary();
            }
            else if (Choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice\n");
            }
        }
    }
}