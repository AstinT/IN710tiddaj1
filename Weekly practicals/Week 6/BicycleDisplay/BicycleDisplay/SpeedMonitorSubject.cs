using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleDisplay
{
    public class SpeedMonitorSubject : ISubject
    {
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

        public void AddObserver(IObserver o)
        {
            observerList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observerList.Remove(o);
        }

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
