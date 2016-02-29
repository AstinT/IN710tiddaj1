using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestMovieDatabase
{
    public class DatabaseManager
    {
        //Dictionary hold all movie
        public Dictionary<int, Movie> movieTable;

        public DatabaseManager()
        {
            movieTable = new Dictionary<int, Movie>();

            //4 preloaded movies
            Movie movie1 = new Movie(1961, "West SideStory", "Jerome Robbins");
            Movie movie2 = new Movie(1972, "The Godfather", "Francis Ford Coppla");
            Movie movie3 = new Movie(1984, "Amadeus", "Milos Forman");
            Movie movie4 = new Movie(2007, "No Country for Old Men", "Ethan & Joel Coen");

            movieTable.Add(movie1.Year, movie1);
            movieTable.Add(movie2.Year, movie2);
            movieTable.Add(movie3.Year, movie3);
            movieTable.Add(movie4.Year, movie4);
        }

        //
        public bool addMovie(int year, String title, String director)
        {
            if (!movieTable.ContainsKey(year))
            {
                Movie newMovie = new Movie(year, title, director);
                movieTable.Add(newMovie.Year, newMovie);
                return true;
            }
            else
                return false;
        }

        public bool deleteMovie(int year)
        {
            if (movieTable.ContainsKey(year))
            {
                movieTable.Remove(year);
                return true;
            }
            else
                return false;
        }

        public Movie searchMovie(int key)
        {
            Movie foundMovie;

            if (movieTable.ContainsKey(key))
            {
                foundMovie = movieTable[key];
            }
            else
                foundMovie = null;

            return foundMovie;
        }

        public String printAll()
        {
            String allMovies = "";

            if (movieTable.Count() != 0)
            {
                foreach (KeyValuePair<int, Movie> currentMovie in movieTable)
                {
                    allMovies += "-------------------------------------\n";
                    allMovies += currentMovie.Value.ToString() + "\n";
                }
            }
            else
            {
                allMovies = null;
            }            
            return allMovies;
        }
    }
}
