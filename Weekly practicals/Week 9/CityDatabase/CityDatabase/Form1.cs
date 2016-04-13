using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityDatabase
{
    public partial class Form1 : Form
    {
        //Fields
        private List<City> cityList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialise cityList
            cityList = new List<City>();

            //New Zealand Cities
            City city1 = new City("Dunedin", "New Zealand", 127500);
            City city2 = new City("Christchurch", "New Zealand", 366100);
            City city3 = new City("Wellington", "New Zealand", 204000);

            //United States of America Cities
            City city4 = new City("New York", "Usa", 8406000);
            City city5 = new City("Boston", "Usa", 645966);

            //Add to cityList
            cityList.Add(city1);
            cityList.Add(city2);
            cityList.Add(city3);
            cityList.Add(city4);
            cityList.Add(city5);   
        }

        //Searches cityList for cities that belong to the country that was entered
        public void SearchCityList()
        {
            //Gets entered country
            String searchedCountry = tbSearchCountry.Text.ToString();

            //Func delegate takes two String arguments and returns a bool
            //Lambda expression if city1 is equal to city2 returns true. If not equal return false.
            Func<String, String, bool> searchCities = (city1, city2) => city1.Equals(city2);

            //Loops cityList
            foreach(City currCity in cityList)
            {
                //Compares the entered country to a country in list
                if (searchCities(searchedCountry, currCity.CountryName))
                    listBox.Items.Add(currCity.ToString());
            }

            //If listBox has no items, nothing was found.
            if(listBox.Items.Count == 0)
            {
                MessageBox.Show("No cities were found with that country!");
            }

            //Reset textBox
            tbSearchCountry.Text = "";
        }

        //Multiply population by 3
        public void MultiplyPopulationBy3()
        {
            //Lambda expression multiples population by 3
            cityList.ForEach((c) => c.Population *= 3);
            //Lambda expression adds all list items ToString to listbox
            cityList.ForEach((c) => listBox.Items.Add(c.ToString()));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Clears listbox
            listBox.Items.Clear();

            //Checks if something has been entered into the textbox
            if (tbSearchCountry.Text != "")
                SearchCityList();
            else
                MessageBox.Show("Please enter a country!");
        }

        private void btnMultiplyPopulation_Click(object sender, EventArgs e)
        {
            //Clears listbox
            listBox.Items.Clear();
            MultiplyPopulationBy3();
        }
    }
}
