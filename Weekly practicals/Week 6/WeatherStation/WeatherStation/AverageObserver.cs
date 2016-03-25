using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public class AverageObserver : WeatherObserver
    {
        //Properties
        private int totalTemprature;
        private int totalHumidity;
        private int totalPressure;
        private int simCount;

        //Constructor
        public AverageObserver(ListBox displayBox, WeatherMonitorSubject weatherSubject)
            : base(displayBox, weatherSubject)
        {
            totalTemprature = 0;
            totalHumidity = 0;
            totalPressure = 0;
            simCount = 0;
        }

        //Update method
        public override void Update(int currentTemprature, int currentHumidity, int currentPressure)
        {
            totalTemprature += currentTemprature;
            totalHumidity += currentHumidity;
            totalPressure += currentPressure;
            simCount += 1;

            //Compute averages
            computedTemprature = totalTemprature / simCount;
            computedHumidity = totalHumidity / simCount;
            computedPressure = totalPressure / simCount;
        }
    }
}
