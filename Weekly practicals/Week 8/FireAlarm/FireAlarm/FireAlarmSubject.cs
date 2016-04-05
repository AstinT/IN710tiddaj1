using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class FireAlarmSubject
    {
        //Delegate
        //Passed a custom EventArgs called FireAlarmEventArgs
        public delegate void FireEventHandler(object fireSubject, FireAlarmEventArgs args);
        
        //Event
        public event FireEventHandler FireEvent;

        public void OnFireEvent(EFireCategory fCat)
        {
            FireAlarmEventArgs args = new FireAlarmEventArgs(fCat);

            if (FireEvent != null)
                FireEvent(this, args);
        }
    }
}
