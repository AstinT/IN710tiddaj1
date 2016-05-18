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
        //Fields
        XDocument pubsAndClubsXML;
        DataGridViewRowCollection dgvRowsEvents;
        DataGridViewRowCollection dgvRowsMembers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Grabs file
            pubsAndClubsXML = XDocument.Load("pubsAndClubs.xml");
            dgvRowsEvents = dataGridView1.Rows;
            dgvRowsMembers = dataGridView2.Rows;
            //Adds new gig
            addNewGig();
        }

        public void searchGigXML(XElement gig)
        {
            //gets all information for displaying a gig
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

            //adds to data grid view
            dgvRowsEvents.Add(newRow);
        }

        public void loadAllUpcomingEvents()
        {
            //Clears data grid view
            dataGridView1.Rows.Clear();            

            //gets all gigs
            foreach (XElement gig in pubsAndClubsXML.Element("Event_Guide").Elements("Gig"))
            {
                searchGigXML(gig);
            }
        }

        public void loadAllHardRockEvents()
        {
            //clears data grid view
            dataGridView1.Rows.Clear();            

            foreach (XElement gig in pubsAndClubsXML.Element("Event_Guide").Elements("Gig"))
            {
                //get all gigs with a genre of Hard Rock
                if(gig.Element("Band").Element("Genre").Value.Trim().Equals("Hard Rock"))
                {
                    searchGigXML(gig);
                }
            }
        }

        public void loadAllGigsThisMonth()
        {
            dataGridView1.Rows.Clear();  

            //Gets current month
            String currMonth = DateTime.Now.ToString("MM");

            foreach (XElement gig in pubsAndClubsXML.Element("Event_Guide").Elements("Gig"))
            {
                //Gets all gigs in the current month
                if (gig.Element("Date").Attribute("month").Value.Trim().Equals(currMonth))
                {
                    searchGigXML(gig);
                }
            }
        }

        public void loadAlabamaShakesMembers()
        {
            dataGridView2.Rows.Clear();

            foreach (XElement gig in pubsAndClubsXML.Element("Event_Guide").Elements("Gig"))
            {
                if (gig.Element("Band").Element("Name").Value.Trim().Equals("Alabama Shakes"))
                {
                    foreach(XElement member in gig.Element("Band").Element("Band_Members").Elements("Member"))
                    {
                        String firstName = member.Element("First_Name").Value;
                        String lastName = member.Element("Last_Name").Value;
                        String name = firstName + " " + lastName;
                        String instrumentNames = "";
                        String role = "";                       
                        
                        foreach(XElement instrument in member.Element("Instruments").Elements("Instrument"))
                        {
                            instrumentNames += instrument.Value + " ";
                        }

                        if (member.Element("Role") == null)
                            role = "No role";
                        else
                            role = member.Element("Role").Value;

                        String[] newRow = { name, instrumentNames, role };

                        dgvRowsMembers.Add(newRow);
                    }
                }
            }
        }

        public void addNewGig()
        {
            //Adds a new gig to the xml
            XElement newGig = new XElement("Gig",
                                                new XElement("Venue", "The Lodge"),
                                                new XElement("Date",
                                                    new XAttribute("day", "03"),
                                                    new XAttribute("month", "04"),
                                                    new XAttribute("year", "2016")),
                                                new XElement("Time", "9:00pm"),
                                                new XElement("Band",
                                                    new XElement("Name", "The Singers"),
                                                    new XElement("Genre", "Country"))
                                           );
            pubsAndClubsXML.Element("Event_Guide").Add(newGig);
            //pubsAndClubsXML.Save("pubsAndClubs.xml");
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
            loadAllGigsThisMonth();
        }

        private void btnBandMembers_Click(object sender, EventArgs e)
        {
            loadAlabamaShakesMembers();
        }   
    }
}
