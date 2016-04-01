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
        public delegate void FeedbackDelegate();
        FeedbackDelegate feedbackDelegate;

        public Form1()
        {
            InitializeComponent();

            feedbackDelegate = null;
        }

        public void slowMethod(FeedbackDelegate operation)
        {
            for (int i = 0; i < 10; i++)
            {                
                operation();
                Thread.Sleep(500);
                Application.DoEvents();
            }            
        }

        public void updateNumericUpDown()
        {
            numericUpDown1.Value++;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(rbNumericUpDown.Checked)
            {
                feedbackDelegate = updateNumericUpDown;
            }

            slowMethod(feedbackDelegate);
        }
    }
}
