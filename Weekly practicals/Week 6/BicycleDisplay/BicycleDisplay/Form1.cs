using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDisplay
{
    public partial class Form1 : Form
    {
        //Properties
        private SpeedMonitorSubject subject;

        public Form1()
        {
            InitializeComponent();
        }

        //Loads up instances of observers
        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new SpeedMonitorSubject();

            new RpmObserver(lblRpm, subject);
            new CaloriesPerHourObserver(lblCalories, subject);
            new KmsPerHourObserver(lblKmsPerHour, subject);
        }

        //
        private void btnChangeSpeed_Click(object sender, EventArgs e)
        {
            int number;

            //try convert input string to int
            if (Int32.TryParse(tbChangeRpm.Text, out number))
            {
                //set CurrentRpm in subject
                subject.CurrentRpm = number;
                //Notify all observers
                subject.NotifyObservers();
            }
            //if nothing is entered or if entered string is not a number
            else
                MessageBox.Show("Please enter a number");

            tbChangeRpm.Text = "";
        }
    }
}
