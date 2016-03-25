using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class WeatherMonitorSubject : ISubject
    {
        //Properties
        private List<IObserver> observerList;
        private int currentTemprature;
        private int currentHumidity;
        private int currentPressure;

        //Constructor
        public WeatherMonitorSubject()
        {
            currentTemprature = 0;
            currentHumidity = 0;
            currentPressure = 0;

            observerList = new List<IObserver>();
        }

        //set only
        public int Temprature
        {
            set { currentTemprature = value; }
        }

        //set only
        public int Humidity
        {
            set { currentHumidity = value; }
        }

        //set only
        public int BarometricPressure
        {
            set { currentPressure = value; }
        }

        //Adds an observer to the observer list
        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }

        //Removes an observer from the observer list
        public void RemoveObserver(IObserver o)
        {
            observerList.Remove(o);
        }

        //Each observer in observerList calls there update and display method
        public void NotifyObservers()
        {
            foreach (IObserver currentObserver in observerList)
            {
                currentObserver.Update(currentTemprature, currentHumidity, currentPressure);
                currentObserver.Display();
            }
        }
    }
}
