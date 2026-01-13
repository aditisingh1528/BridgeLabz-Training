using System;
using CinemaTime;

public class MovieMain
{
    static void Main(string[] args)
    {
        IMovieService service = new MovieUtilityImpl();
        MovieMenu.ShowMenu(service);
    }
}