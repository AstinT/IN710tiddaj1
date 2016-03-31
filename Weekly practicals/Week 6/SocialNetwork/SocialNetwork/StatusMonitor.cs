using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork
{
    public class StatusMonitor : ISubject
    {
        //Properties
        private List<IObserver> observerList;
        private String newStatus;

        //Constructor
        public StatusMonitor()
        {
            observerList = new List<IObserver>();
            newStatus = "";
        }

        //Getter and setter
        public String NewStatus
        {
            get { return newStatus; }
            set { newStatus = value; }
        }

        //Methods
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
            foreach(IObserver currObserver in observerList)
            {
                currObserver.Update(newStatus);
                currObserver.Display();
            }
        }
    }
}
