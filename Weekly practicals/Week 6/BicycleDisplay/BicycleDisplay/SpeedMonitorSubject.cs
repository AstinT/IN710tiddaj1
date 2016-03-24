using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleDisplay
{
    public class SpeedMonitorSubject : ISubject
    {
        //Properties
        private List<IObserver> observerList;
        public int currentRpm;

        //Constructor
        public SpeedMonitorSubject()
        {
            currentRpm = 0;
            observerList = new List<IObserver>();
        }

        //set only
        public int CurrentRpm
        {
            set { currentRpm = value; }
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
                currentObserver.Update(currentRpm);
                currentObserver.Display();
            }                
        }
    }
}
