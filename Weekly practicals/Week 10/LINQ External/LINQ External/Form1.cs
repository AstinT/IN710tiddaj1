using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_External
{
    public partial class Form1 : Form
    {
        //Field
        //Reference to database
        private StrikesDbDataContext db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creating database
            db = new StrikesDbDataContext();
        }        

        //Average intensity for all strikes
        private void btnAveStrike_Click(object sender, EventArgs e)
        {
            //Clear list box
            listBox1.Items.Clear();

            //Computes average strike intensity of all records
            double aveStrikes = db.tblStrikes.Average(s => s.strikeIntensity);

            //Displays aveStrikes to listbox
            listBox1.Items.Add(aveStrikes.ToString());
        }

        //Records of the largest three fires
        private void btnLargeThreeFires_Click(object sender, EventArgs e)
        {
            //Clear list box
            listBox1.Items.Clear();

            //Orders all fire records by fireArea in descending order (largest to smallest)
            //Takes the top three
            var threeBiggestFires = db.tblFires.OrderByDescending(f => f.fireArea).Take(3);

            //Displays the three records to listbox
            foreach (var record in threeBiggestFires)
            {
                listBox1.Items.Add(record.fireDate + "\t\t" + record.fireArea);
            }
        }

        //Display latitude, longitude and filename for each picture
        private void btnPictures_Click(object sender, EventArgs e)
        {
            //Clear list box
            listBox1.Items.Clear();

            //Join tblPicture to tblStrikes
            //On strikeID
            //Select latitude, longitude and filename
            var allPics = from p in db.tblPictures
                          join s in db.tblStrikes
                          on p.strikeID equals s.strikeID
                          select new { s.strikeLatitude, s.strikeLongitude, p.pictureFileName };

            //Display all records to listbox
            foreach (var record in allPics)
            {
                listBox1.Items.Add(record.strikeLatitude + "\t\t" + record.strikeLongitude + "\t\t" + record.pictureFileName);
            }
        }

        //All fires caused by lightning strike
        private void btnFireStrikes_Click(object sender, EventArgs e)
        {
            //Clear list box
            listBox1.Items.Clear();

            //Join tblStrike to tblFires
            //On strikeDate == fireDate
            //Where strikeLongitude == fireLongitude &&
            //strikeLatitude == fireLatitude
            //select f record
            var fireStrikes = from s in db.tblStrikes
                              join f in db.tblFires
                              on s.strikeDate equals f.fireDate
                              where s.strikeLongitude == f.fireLongitude &&
                                    s.strikeLatitude == f.fireLatitude
                              select f;

            //Display all records to listbox
            foreach (var record in fireStrikes)
            {
                listBox1.Items.Add(record.fireDate + "\t\t" + record.fireArea);
            }
        }
    }
}
