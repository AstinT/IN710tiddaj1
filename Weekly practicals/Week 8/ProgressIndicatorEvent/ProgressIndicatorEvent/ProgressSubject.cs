using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgressIndicatorEvent
{
    public class ProgressSubject
    {
        //Event
        public event EventHandler ProgressUpdateEvent;

        public void OnUpdateEvent()
        {
            EventArgs args = new EventArgs();

            if (ProgressUpdateEvent != null)
                ProgressUpdateEvent(this, args);
        }

        public void SlowMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnUpdateEvent();
            }
        }
    }
}
