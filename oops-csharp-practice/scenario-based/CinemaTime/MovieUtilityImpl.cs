using System;

namespace CinemaTime
{
    public class MovieUtilityImpl : IMovieService
    {
        private string[] titles = new string[10];
        private string[] times = new string[10];
        private int count = 0;

        public void AddMovie(string title, string time)
        {
            if (count >= titles.Length)
            {
                Console.WriteLine("Movie Storage Full");
                return;
            }

            titles[count] = title;
            times[count] = time;
            count++;

            Console.WriteLine("Movie Added Successfully!");
        }

        public void SearchMovie(string keyword)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (titles[i].ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine($"Movie: {titles[i]} | Time: {times[i]}");
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Movie Not Found");
        }

        public void DisplayAllMovies()
        {
            if (count == 0)
            {
                Console.WriteLine("No Movies Available");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Movie: {titles[i]} | Time: {times[i]}");
            }
        }
    }
}