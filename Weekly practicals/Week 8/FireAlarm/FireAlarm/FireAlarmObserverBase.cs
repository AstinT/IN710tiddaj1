using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public abstract class FireAlarmObserverBase
    {
        protected FireAlarmSubject subject;

        public FireAlarmObserverBase(FireAlarmSubject subject)
        {
            this.subject = subject;

            FireAlarmSubject.FireEventHandler handler =
                new FireAlarmSubject.FireEventHandler(AlarmMethod);

            subject.FireEvent += handler;
        }

        public abstract void AlarmMethod(object fireSubject, FireAlarmEventArgs args);
    }
}
