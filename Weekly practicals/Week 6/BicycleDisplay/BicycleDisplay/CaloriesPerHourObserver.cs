using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDisplay
{
    //Child class
    public class CaloriesPerHourObserver : BicycleObserver
    {
        //Constructor
        public CaloriesPerHourObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
            : base(displayLabel, bikeSubject)
        {
        }

        //Update method
        public override void Update(int currentRpm)
        {
            currentComputedValue = currentRpm * 5;
        }
    }
}