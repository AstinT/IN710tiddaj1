using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public class InstructionsObserver : FireAlarmObserverBase
    {
        public InstructionsObserver(FireAlarmSubject subject) : base(subject)
        {
            //nothing here
        }

        public override void AlarmMethod(object fireSubject, FireAlarmEventArgs args)
        {
            String message = "Fire is " + args.FireCategory.ToString() + ".";
            switch (args.FireCategory)
            {
                case EFireCategory.MINOR:
                    message += " Use a fire extinguisher.";
                    break;
                case EFireCategory.SERIOUS:
                    message += " Call the Fire Department.";
                    break;
                case EFireCategory.INFERNO:
                    message += " Run for your life!!!!!.";
                    break;
            }

            MessageBox.Show(message);
        }
    }
}
