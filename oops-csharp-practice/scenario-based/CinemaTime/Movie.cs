using System;

namespace CinemaTime
{
    public class Movie
    {
        private string title;
        private string time;

        public Movie(string title, string time)
        {
            this.title = title;
            this.time = time;
        }

        public string Title
        {
            get { return title; }
        }

        public string Time
        {
            get { return time; }
        }
    }
}