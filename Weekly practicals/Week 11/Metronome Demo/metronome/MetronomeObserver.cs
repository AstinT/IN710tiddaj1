using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace metronome
{
    public class MetronomeObserver
    {
        protected Metronome metronome;

        public MetronomeObserver(Metronome metronome)
        {
            this.metronome = metronome;
            metronome.metronomeEvent += new Metronome.metronomeEventHandler(onMetronomeEvent);
        }

        public virtual void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            MessageBox.Show("My metronome clicked");
        }

    }

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Beeper : MetronomeObserver
    {
        private String soundFileName;
        private SoundPlayer soundPlayer;

        public Beeper(Metronome metronome, String soundFileName)
            : base(metronome)
        {
            this.soundFileName = soundFileName;
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = soundFileName;
        }


        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            soundPlayer.Play();
        }

    } // end TBeeper
    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class Counter : MetronomeObserver
    {
        private NumericUpDown spinBox;
        private int count;

        public Counter(Metronome metronome, NumericUpDown spinBox)
            : base(metronome)
        {
            this.spinBox = spinBox;
            count = 0;
        }

        delegate void delegateSetSpinnerValue(int count);

        //Set spinBox vaule to count
        private void SetSpinnerValue(int count)
        {
            spinBox.Value = count;
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            //Increment count
            count++;

            //Check if spinBox is invoked
            if(spinBox.InvokeRequired)
            {
                delegateSetSpinnerValue setSpinner = SetSpinnerValue;
                //Invokes spin box with delegate and count
                spinBox.Invoke(setSpinner, count);
            }
            else
            {
                //Calls SetSpinnerValue method
                SetSpinnerValue(count);
            }
        }
    } // end TCounter

    //----------------------------------------------------------------------------
    //----------------------------------------------------------------------------
    public class TimeDisplay : MetronomeObserver
    {
        private ListBox listBox;

        public TimeDisplay(Metronome metronome, ListBox listBox)
            : base(metronome)
        {
            this.listBox = listBox;
        }

        delegate void delegateSetListBoxText(DateTime currDateTime);

        //Adds current date and time to listBox
        private void SetListBoxText(DateTime currDateTime)
        {
            listBox.Items.Add(currDateTime.ToString());
        }

        public override void onMetronomeEvent(object sender, metronomeEventArgs e)
        {
            //Grab current DateTime from metronomeEventArgs
            DateTime currDateTime = e.currentTime;

            //Checks if listBox is invoked
            if(listBox.InvokeRequired)
            {                
                delegateSetListBoxText setListBox = SetListBoxText;
                //Invokes Listbox with delegate and currDateTime
                listBox.Invoke(setListBox, currDateTime);
            }
            else
            {
                //Calls SetListBoxText method
                SetListBoxText(currDateTime);
            }         
        }
    }            
}
