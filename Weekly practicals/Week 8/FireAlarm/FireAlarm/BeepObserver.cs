using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class BeepObserver : FireAlarmObserverBase
    {
        //Import old kernel beep
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);

        //Constructor
        public BeepObserver(FireAlarmSubject subject) : base(subject)
        {
            //nothing here
        }

        public override void AlarmMethod(object fireSubject, FireAlarmEventArgs args)
        {
            //Switch statement checks what fire category was passed in.
            switch (args.FireCategory)
            {
                case EFireCategory.MINOR:
                    Beep(300, 2000);
                    break;
                case EFireCategory.SERIOUS:
                    Beep(600, 2000);
                    break;
                case EFireCategory.INFERNO:
                    Beep(900, 2000);
                    break;
            }
        }
    }
}
