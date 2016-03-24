using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public abstract class WeatherObserver : IObserver
    {
        //Properties
        protected int currentTemprature;
        protected int currentHumidity;
        protected int currentBarometricPressure;
        protected ListBox displayBox;
        protected WeatherMonitorSubject weatherSubject;

        //Constructor
        public WeatherObserver(ListBox displayBox, WeatherMonitorSubject weatherSubject)
        {
            this.displayBox = displayBox;
            this.weatherSubject = weatherSubject;

            currentTemprature = 0;
            currentHumidity = 0;
            currentBarometricPressure = 0;

            weatherSubject.AddObserver(this);
        }

        public abstract void Update(int currentTemprature, int currentHumidity, int currentBarometricPressure);
        public abstract void Display();
    }
}
