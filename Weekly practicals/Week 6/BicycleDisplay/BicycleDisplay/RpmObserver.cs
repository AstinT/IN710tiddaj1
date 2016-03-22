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

        }

        public override void Update(int currentRpm)
        {
            currentComputedValue = currentRpm;
        }
    }
}