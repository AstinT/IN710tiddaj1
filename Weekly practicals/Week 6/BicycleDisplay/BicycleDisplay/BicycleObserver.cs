using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDisplay
{
    //Base class
    public abstract class BicycleObserver : IObserver
    {
        //Properties
        protected int currentRpm;
        protected double currentComputedValue;
        protected Label displayLabel;
        protected SpeedMonitorSubject bikeSubject;

        //Constructor
        public BicycleObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
        {
            this.displayLabel = displayLabel;
            this.bikeSubject = bikeSubject;

            currentRpm = 0;
            currentComputedValue = 0;

            //Observer adds itself
            bikeSubject.AddObserver(this);
        }

        public abstract void Update(int currentRpm);

        //Concrete method Display
        //sets the display text to the currentComputedValue
        public void Display()
        {
            displayLabel.Text = currentComputedValue.ToString("F2");
        }
    }
}