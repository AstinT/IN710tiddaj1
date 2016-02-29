using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestMovieDatabase
{
    public class Movie
    {
        //Properties
        public int Year { get; set; }
        public String Title { get; set; }
        public String Director { get; set; }

        //Constructor
        public Movie(int year, String title, String director)
        {
            Year = year;
            Title = title;
            Director = director;
        }

        public override string ToString()
        {
            return Year.ToString() + " " + Title + " " + Director;
        }
    }
}
