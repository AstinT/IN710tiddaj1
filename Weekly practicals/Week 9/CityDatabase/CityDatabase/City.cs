using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDatabase
{
    public class City
    {
        //Properties
        public String CityName { get; set; }
        public String CountryName { get; set; }
        public int Population { get; set; }

        //Constructor
        public City(String cityName, String countryName, int population)
        {
            CityName = cityName;
            CountryName = countryName;
            Population = population;
        }
    }
}
