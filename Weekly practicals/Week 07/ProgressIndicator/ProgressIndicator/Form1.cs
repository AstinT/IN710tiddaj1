using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicator
{
    public partial class Form1 : Form
    {
        //Declare delegate
        public delegate void FeedbackDelegate();
        FeedbackDelegate feedbackDelegate;

        public Form1()
        {
            InitializeComponent();

            //Initialise as null
            feedbackDelegate = null;
        }

        //Method that gets passed a delegate
        public void slowMethod(FeedbackDelegate operation)
        {
            for (int i = 0; i < 10; i++)
            {                
                operation();
                Thread.Sleep(500);
                Application.DoEvents();
            }            
        }

        //Increments NumericUpDown
        public void updateNumericUpDown()
        {
            numericUpDown1.Value++;
        }

        //Increments TrackBar
        public void updateTrackBar()
        {
            trackBar1.Value++;
        }

        //Increments ProgressBar
        public void updateProgressBar()
        {
            progressBar1.Increment(1);
        }

        //Checks what radiobutton is checked and assigns appropriate method to delegate
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbNumericUpDown.Checked)
            {
                feedbackDelegate = updateNumericUpDown;
            }
            else if (rbTrackBar.Checked)
            {
                feedbackDelegate = updateTrackBar;
            }
            else
            {
                feedbackDelegate = updateProgressBar;
            }

            //Takes a delegate as arugment
            slowMethod(feedbackDelegate);
        }
    }
}
