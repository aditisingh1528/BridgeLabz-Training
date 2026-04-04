using System;

namespace CinemaTime
{
    public class MovieMenu
    {
        public static void ShowMenu(IMovieService service)
        {
            int choice;

            do
            {
                Console.WriteLine("\nCINEMA TIME");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Search Movie");
                Console.WriteLine("3. View All Movies");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter movie name: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter show time: ");
                        string time = Console.ReadLine();

                        service.AddMovie(title, time);
                        break;

                    case 2:
                        Console.Write("Enter keyword: ");
                        string keyword = Console.ReadLine();

                        service.SearchMovie(keyword);
                        break;

                    case 3:
                        service.DisplayAllMovies();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 4);
        }
    }
}