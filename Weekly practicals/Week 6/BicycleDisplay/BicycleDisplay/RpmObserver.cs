using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDisplay
{
    public class RpmObserver : BicycleObserver
    {
        public RpmObserver(Label displayLabel, SpeedMonitorSubject bikeSubject) 
            : base(displayLabel, bikeSubject)
        {
            currentRpm = 0;
            currentComputedValue = 0;
        }

        public override void Update(int data)
        {
            displayLabel.Text = currentRpm.ToString();
        }
    }
}