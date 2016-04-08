using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgressIndicatorEvent
{
    public class TrackBarObserver : ProgressObserverBase
    {
        private TrackBar trackBar;

        public TrackBarObserver(ProgressSubject subject, TrackBar trackBar)
            : base(subject)
        {
            this.trackBar = trackBar;
        }

        public override void UpdateMethod(object progressSubject, EventArgs args)
        {
            trackBar.Value++;
        }
    }
}
