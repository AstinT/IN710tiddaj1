using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public class AllValuesObserver : WeatherObserver
    {
        //Constructor
        public AllValuesObserver(ListBox displayBox, WeatherMonitorSubject weatherSubject)
            : base(displayBox, weatherSubject)
        {
        }

        //Update method
        public override void Update(int currentTemprature, int currentHumidity, int currentPressure)
        {
            computedTemprature = currentTemprature;
            computedHumidity = currentHumidity;
            computedPressure = currentPressure;
        }
    }
}
