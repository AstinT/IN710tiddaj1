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

        //Methods
        public override String ToString()
        {
            return String.Format("{0,-20} | {1,-20} | {2,10}", CityName, CountryName, Population);
        }
    }
}
