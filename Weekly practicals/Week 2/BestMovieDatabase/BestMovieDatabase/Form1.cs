using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestMovieDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DatabaseManager dbManager = new DatabaseManager(); 

        public void addMovie()
        {
            int year = Convert.ToInt32(tbAddMovieYear.Text);
            String title = tbAddMovieTitle.Text;
            String director = tbAddDirector.Text;

            bool checkAdded = dbManager.addMovie(year, title, director);

            if (checkAdded == true)
                MessageBox.Show("Succesfully added");
            else
                MessageBox.Show("Movie already in database");
            
            tbAddMovieYear.Text = "";
            tbAddMovieTitle.Text = "";
            tbAddDirector.Text = "";
        }

        public void deleteMovie()
        {
            try
            {
                int year = Convert.ToInt32(tbDeleteMovieYear.Text);

                bool checkDeleted = dbManager.deleteMovie(year);

                if (checkDeleted == true)
                    MessageBox.Show("Succesfully deleted");
                else
                    MessageBox.Show("Movie doesn't exsit");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter only numbers");
            }           

            tbDeleteMovieYear.Text = "";
        }

        public void searchMovie()
        {
            rtDisplay.Text = "";

            try
            {
                int key = Convert.ToInt32(tbSearchYear.Text);

                Movie searchedMovie = dbManager.searchMovie(key);

                if (searchedMovie != null)
                {
                    rtDisplay.Text = searchedMovie.ToString();
                }
                else
                    MessageBox.Show("Movie not found");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter only numbers");
            }
            
            tbSearchYear.Text = "";
        }

        public void printAll()
        {
            rtDisplay.Text = "";
            String allMovies = dbManager.printAll();

            if (allMovies != null)
                rtDisplay.Text = allMovies;
            else
                MessageBox.Show("No movies found in database");
        }
        
        //Button methods
        //Add movie to database
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            addMovie();
        }

        //Delete movie from database
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            deleteMovie();
        }

        //Search movie from database
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchMovie();
        }

        //Print all movies from database to listbox
        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            printAll();
        }
    }
}
