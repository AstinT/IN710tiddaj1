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

        //Called from form.
        public void OnFireEvent(EFireCategory fCat)
        {
            //Passes current fire category
            FireAlarmEventArgs args = new FireAlarmEventArgs(fCat);

            //If FireEvent observer list is not empty...
            //Passes args to all subscribed observers
            if (FireEvent != null)
                FireEvent(this, args);
        }
    }
}
