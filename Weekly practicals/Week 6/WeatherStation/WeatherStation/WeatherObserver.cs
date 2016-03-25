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
        protected int currentPressure;
        protected int computedTemprature;
        protected int computedHumidity;
        protected int computedPressure;
        protected ListBox displayBox;
        protected WeatherMonitorSubject weatherSubject;

        //Constructor
        public WeatherObserver(ListBox displayBox, WeatherMonitorSubject weatherSubject)
        {
            this.displayBox = displayBox;
            this.weatherSubject = weatherSubject;

            currentTemprature = 0;
            currentHumidity = 0;
            currentPressure = 0;
            computedTemprature = 0;
            computedHumidity = 0;
            computedPressure = 0;

            //Observer adds itself
            weatherSubject.AddObserver(this);
        }

        public abstract void Update(int currentTemprature, int currentHumidity, int currentPressure);

        //Virtual method because ForecastObserver needs to display information differently using strings.
        public virtual void Display()
        {
            displayBox.Items.Clear();
            displayBox.Items.Add(computedTemprature);
            displayBox.Items.Add(computedHumidity);
            displayBox.Items.Add(computedPressure);  
        }
    }
}
