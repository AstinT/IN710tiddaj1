using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDisplay
{
    //Child class
    public class KmsPerHourObserver : BicycleObserver
    {
        //Constant
        private const double WHEEL_CIRCUMFERENCE = 2.05;

        //Constructor
        public KmsPerHourObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
            : base(displayLabel, bikeSubject)
        {
        }

        //Update method
        public override void Update(int currentRpm)
        {
            currentComputedValue = (currentRpm * WHEEL_CIRCUMFERENCE * 60) / 1000;
        }
    }
}