using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicatorEvent
{
    public partial class Form1 : Form
    {
        ProgressSubject slowWorker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            slowWorker = new ProgressSubject();

            new TrackBarObserver(slowWorker, trackBar);
            new ProgressBarObserver(slowWorker, progressBar);
            new NumericUpDownObserver(slowWorker, numericUpDown);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            slowWorker.SlowMethod();
        }
    }
}
