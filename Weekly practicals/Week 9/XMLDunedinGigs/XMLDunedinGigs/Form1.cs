using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLDunedinGigs
{
    public partial class Form1 : Form
    {
        XDocument pubsAndClubsXML;
        DataGridViewRowCollection dgvRows;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pubsAndClubsXML = XDocument.Load("pubsAndClubs.xml");
            dgvRows = dataGridView1.Rows;
        }

        public void loadAllUpcomingEvents()
        {
            dataGridView1.Rows.Clear();            

            foreach (XElement gig in pubsAndClubsXML.Element("Event_Guide").Elements("Gig"))
            {
                String bandName = gig.Element("Band").Element("Name").Value;
                String genre = gig.Element("Band").Element("Genre").Value;
                String venue = gig.Element("Venue").Value;
                String day = gig.Element("Date").Attribute("day").Value;
                String month = gig.Element("Date").Attribute("month").Value;
                String year = gig.Element("Date").Attribute("year").Value;
                String time = gig.Element("Time").Value;

                String date = day + "/" + month + "/" + year;
                String dateTime = date + "  " + time;

                String[] newRow = { bandName, genre, venue, dateTime };

                dgvRows.Add(newRow);
            }
        }

        public void loadAllHardRockEvents()
        {
            dataGridView1.Rows.Clear();            

            foreach (XElement gig in pubsAndClubsXML.Element("Event_Guide").Elements("Gig"))
            {
                if(gig.Element("Band").Element("Genre").Value.Trim().Equals("Hard Rock"))
                {
                    String bandName = gig.Element("Band").Element("Name").Value;
                    String genre = gig.Element("Band").Element("Genre").Value;
                    String venue = gig.Element("Venue").Value;
                    String day = gig.Element("Date").Attribute("day").Value;
                    String month = gig.Element("Date").Attribute("month").Value;
                    String year = gig.Element("Date").Attribute("year").Value;
                    String time = gig.Element("Time").Value;

                    String date = day + "/" + month + "/" + year;
                    String dateTime = date + "  " + time;

                    String[] newRow = { bandName, genre, venue, dateTime };

                    dgvRows.Add(newRow);
                }
            }
        }

        private void btnAllUpcomingEvents_Click(object sender, EventArgs e)
        {
            loadAllUpcomingEvents();
        }

        private void btnHardRock_Click(object sender, EventArgs e)
        {
            loadAllHardRockEvents();
        }

        private void btnCurrentMonth_Click(object sender, EventArgs e)
        {

        }        
    }
}
