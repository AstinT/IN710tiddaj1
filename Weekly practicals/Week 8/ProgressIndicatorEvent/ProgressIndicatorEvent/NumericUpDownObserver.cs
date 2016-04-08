using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgressIndicatorEvent
{
    public class NumericUpDownObserver : ProgressObserverBase
    {
        private NumericUpDown numericUpDown;

        public NumericUpDownObserver(ProgressSubject subject, NumericUpDown numericUpDown)
            : base(subject)
        {
            this.numericUpDown = numericUpDown;
        }

        public override void UpdateMethod(object progressSubject, EventArgs args)
        {
            numericUpDown.Value++;
            numericUpDown.Refresh();
        }
    }
}
