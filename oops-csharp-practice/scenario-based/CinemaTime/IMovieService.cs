using System;

namespace CinemaTime
{
    public interface IMovieService
    {
        void AddMovie(string title, string time);
        void SearchMovie(string keyword);
        void DisplayAllMovies();
    }
}