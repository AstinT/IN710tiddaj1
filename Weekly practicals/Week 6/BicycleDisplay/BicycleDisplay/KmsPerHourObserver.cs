using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDisplay
{
    public class KmsPerHourObserver : BicycleObserver
    {
        private const double WHEEL_CIRCUMFERENCE = 2.05;

        public KmsPerHourObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
            : base(displayLabel, bikeSubject)
        {

        }

        public override void Update(int currentRpm)
        {
            currentComputedValue = (currentRpm * WHEEL_CIRCUMFERENCE * 60) * 0.001;
        }
    }
}