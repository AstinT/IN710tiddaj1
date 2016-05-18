using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public class ForecastObserver : WeatherObserver
    {
        //Properties
        private String prediction;

        //Constructor
        public ForecastObserver(ListBox displayBox, WeatherMonitorSubject weatherSubject)
            : base(displayBox, weatherSubject)
        {
        }

        //Update method
        public override void Update(int currentTemprature, int currentHumidity, int currentPressure)
        {
            //Predicts weather using barometric pressure
            if (currentPressure == 1020)
            {
                prediction = "Nice weather";
            }
            else
            {
                prediction = "Bad weather";
            }
        }

        //Override Display method and display prediction
        public override void Display()
        {
            displayBox.Items.Clear();
            displayBox.Items.Add(prediction);
        } 
    }
}
