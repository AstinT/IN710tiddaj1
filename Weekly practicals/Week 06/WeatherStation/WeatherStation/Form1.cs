using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class Form1 : Form
    {
        //Properties
        private WeatherMonitorSubject subject;

        public Form1()
        {
            InitializeComponent();

            subject = new WeatherMonitorSubject();

            //new observers
            new AllValuesObserver(lbReadings, subject);
            new AverageObserver(lbAverageReadings, subject);
            new ForecastObserver(lbForecast, subject);
        }

        private void btnUpdateMeasurements_Click(object sender, EventArgs e)
        {
            int temperature;
            int humidity;
            int barometricPressure;

            //try convert input string to int
            if (Int32.TryParse(tbTemprature.Text, out temperature) &&
                Int32.TryParse(tbHumidity.Text, out humidity) &&
                Int32.TryParse(tbBarometricPressure.Text, out barometricPressure))
            {
                if ((humidity < 0) || (humidity > 100))
                {
                    MessageBox.Show("Please enter a humidity between 0-100%.");
                }                    
                else
                {
                     //set
                    subject.Temprature = temperature;
                    subject.Humidity = humidity;
                    subject.BarometricPressure = barometricPressure;
                    //Notify all observers
                    subject.NotifyObservers();
                }
               
            }
            //if nothing is entered or if entered string is not a number
            else
                MessageBox.Show("Please enter a number and fill out all text boxes.");

            tbTemprature.Text = "";
            tbHumidity.Text = "";
            tbBarometricPressure.Text = "";

        }
    }
}
