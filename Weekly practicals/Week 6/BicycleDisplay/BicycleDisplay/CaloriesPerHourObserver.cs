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
            currentRpm = 0;
            currentComputedValue = 0;
        }

        public override void Update(int data)
        {
            int calPerHour = currentRpm * 5;
            displayLabel.Text = calPerHour.ToString();
        }
    }
}