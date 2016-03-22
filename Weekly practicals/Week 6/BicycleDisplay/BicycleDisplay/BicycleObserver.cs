using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDisplay
{
    public abstract class BicycleObserver : IObserver
    {
        protected int currentRpm;
        protected double currentComputedValue;
        protected Label displayLabel;
        protected SpeedMonitorSubject bikeSubject;

        public BicycleObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
        {
            this.displayLabel = displayLabel;
            this.bikeSubject = bikeSubject;
        }

        public abstract void Update(int data);

        public void Display()
        {
            displayLabel.Text = currentComputedValue.ToString();
        }
    }
}