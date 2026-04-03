using System;

class LibraryManagementSystem
{
    static int maxBooks = 10;
    static int bookCount = 3;

    // title | author | status
    static string[,] books = new string[10, 3];

    static void Main()
    {
        // Initialize existing books
        books[0, 0] = "The Alchemist";
        books[0, 1] = "Paulo Coelho";
        books[0, 2] = "Available";

        books[1, 0] = "Clean Code";
        books[1, 1] = "Robert Martin";
        books[1, 2] = "Available";

        books[2, 0] = "Harry Potter";
        books[2, 1] = "J.K. Rowling";
        books[2, 2] = "Checked Out";

        Console.WriteLine("Select Role:");
        Console.WriteLine("1. Librarian");
        Console.WriteLine("2. Customer");
        Console.Write("Enter choice: ");
        int role = Convert.ToInt32(Console.ReadLine());

        switch (role)
        {
            case 1:
                LibrarianMenu();
                break;
            case 2:
                CustomerMenu();
                break;
            default:
                Console.WriteLine("Invalid role.");
                break;
        }
    }

    //Librarian
    static void LibrarianMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Librarian Menu ---");
            Console.WriteLine("1. Search Book");
            Console.WriteLine("2. Check Book Status");
            Console.WriteLine("3. Add Book");
            Console.WriteLine("4. Delete Book");
            Console.WriteLine("5. Display All Books");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SearchBook(ReadInput("Enter title keyword: "));
                    break;
                case 2:
                    CheckStatus(ReadInput("Enter exact book title: "));
                    break;
                case 3:
                    AddBook();
                    break;
                case 4:
                    DeleteBook(ReadInput("Enter exact book title: "));
                    break;
                case 5:
                    DisplayAllBooks();
                    break;
            }
        } while (choice != 56);
    }

    //Customer
    static void CustomerMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Customer Menu ---");
            Console.WriteLine("1. Search Book");
            Console.WriteLine("2. Check Book Status");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Display All Books");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SearchBook(ReadInput("Enter title keyword: "));
                    break;
                case 2:
                    CheckStatus(ReadInput("Enter exact book title: "));
                    break;
                case 3:
                    BorrowBook(ReadInput("Enter exact book title: "));
                    break;
                case 4:
                    ReturnBook(ReadInput("Enter exact book title: "));
                    break;
                case 5:
                    DisplayAllBooks();
                    break;
            }
        } while (choice != 5);
    }

    //Common Features
    static void SearchBook(string keyword)
    {
        bool found = false;
        Console.WriteLine("\nSearch Results:");

        for (int i = 0; i < bookCount; i++)
        {
            if (books[i, 0].ToLower().Contains(keyword.ToLower()))
            {
                Console.WriteLine($"{books[i, 0]} | {books[i, 1]} | {books[i, 2]}");
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No book found.");
    }

    static void CheckStatus(string title)
    {
        for (int i = 0; i < bookCount; i++)
        {
            if (books[i, 0].Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Status: {books[i, 2]}");
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    static void DisplayAllBooks()
    {
        Console.WriteLine("\n--- All Books in Library ---");
        for (int i = 0; i < bookCount; i++)
        {
            Console.WriteLine($"{books[i, 0]} | {books[i, 1]} | {books[i, 2]}");
        }
    }

    static void BorrowBook(string title)
    {
        for (int i = 0; i < bookCount; i++)
        {
            if (books[i, 0].Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                if (books[i, 2] == "Available")
                {
                    books[i, 2] = "Checked Out";
                    Console.WriteLine("Book borrowed successfully.");
                }
                else
                {
                    Console.WriteLine("Book already borrowed.");
                }
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    static void ReturnBook(string title)
    {
        for (int i = 0; i < bookCount; i++)
        {
            if (books[i, 0].Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                if (books[i, 2] == "Checked Out")
                {
                    books[i, 2] = "Available";
                    Console.WriteLine("Book returned successfully.");
                }
                else
                {
                    Console.WriteLine("Book is already available.");
                }
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    //Librarian
    static void AddBook()
    {
        if (bookCount >= maxBooks)
        {
            Console.WriteLine("Library is full.");
            return;
        }

        Console.Write("Enter title: ");
        string title = Console.ReadLine();

        Console.Write("Enter author: ");
        string author = Console.ReadLine();

        books[bookCount, 0] = title;
        books[bookCount, 1] = author;
        books[bookCount, 2] = "Available";

        bookCount++;
        Console.WriteLine("Book added successfully.");
    }

    static void DeleteBook(string title)
    {
        for (int i = 0; i < bookCount; i++)
        {
            if (books[i, 0].Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                for (int j = i; j < bookCount - 1; j++)
                {
                    books[j, 0] = books[j + 1, 0];
                    books[j, 1] = books[j + 1, 1];
                    books[j, 2] = books[j + 1, 2];
                }
                bookCount--;
                Console.WriteLine("Book deleted successfully.");
                return;
            }
        }
        Console.WriteLine("Book not found.");
    }

    static string ReadInput(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
}
