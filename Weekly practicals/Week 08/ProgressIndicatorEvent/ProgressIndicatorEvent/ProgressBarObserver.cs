using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgressIndicatorEvent
{
    public class ProgressBarObserver : ProgressObserverBase
    {
        private ProgressBar progressBar;

        public ProgressBarObserver(ProgressSubject subject, ProgressBar progressBar)
            : base(subject)
        {
            this.progressBar = progressBar;
        }

        public override void UpdateMethod(object progressSubject, EventArgs args)
        {
            progressBar.Value++;
        }
    }
}
