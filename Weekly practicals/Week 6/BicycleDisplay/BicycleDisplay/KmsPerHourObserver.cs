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
        private const int WHEEL_CIRCUMFERENCE = 205;

        public KmsPerHourObserver(Label displayLabel, SpeedMonitorSubject bikeSubject)
            : base(displayLabel, bikeSubject)
        {
            currentRpm = 0;
            currentComputedValue = 0;
        }

        public override void Update(int data)
        {

        }
    }
}