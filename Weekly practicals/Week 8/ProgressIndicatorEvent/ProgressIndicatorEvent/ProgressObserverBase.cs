using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressIndicatorEvent
{
    public abstract class ProgressObserverBase
    {
        //Properties
        protected ProgressSubject subject;

        //Constructor
        public ProgressObserverBase(ProgressSubject subject)
        {
            this.subject = subject;

            System.EventHandler handler =
                new System.EventHandler(UpdateMethod);

            subject.ProgressUpdateEvent += handler;
        }

        //Methods
        public abstract void UpdateMethod(object subject, EventArgs args);
    }
}
