using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDisplay
{
    public class CaloriesPerHourObserver : BicycleObserver
    {
        public CaloriesPerHourObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
            : base(displayLabel, bikeSubject)
        {

        }

        public override void Update(int data)
        {
            currentComputedValue = currentRpm * 5;
        }
    }
}