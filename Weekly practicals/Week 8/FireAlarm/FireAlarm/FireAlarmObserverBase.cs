using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public abstract class FireAlarmObserverBase
    {
        //Properties
        protected FireAlarmSubject subject;

        //Constructor
        public FireAlarmObserverBase(FireAlarmSubject subject)
        {
            this.subject = subject;

            //Binding AlarmMethod to FireEventHandler
            FireAlarmSubject.FireEventHandler handler =
                new FireAlarmSubject.FireEventHandler(AlarmMethod);

            //Adds observer to FireEvent list
            subject.FireEvent += handler;
        }

        //Methods
        public abstract void AlarmMethod(object fireSubject, FireAlarmEventArgs args);
    }
}
