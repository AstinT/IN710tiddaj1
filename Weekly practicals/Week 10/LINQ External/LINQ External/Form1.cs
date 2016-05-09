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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAveStrike_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();

            //StrikesDbDataContext db = new StrikesDbDataCo

            //var aveStikes = db.tblStrikes.Average(s => s.strikeIntensity);

            //foreach (var record in aveStikes)
            //{
            //    listBox1.Items.Add(record)
            //}
        }

        private void btnLargeThreeFires_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();

            //StrikesDbDataContext db = new StrikesDbDataContext();

            //var threeLargeStrikes = from f in db.tblFires
            //                        where f.fireArea

            //foreach()
            //{

            //}
        }

        private void btnPictures_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            StrikesDbDataContext db = new StrikesDbDataContext();

            var allPics = from p in db.tblPictures
                          join s in db.tblStrikes
                          on p.strikeID equals s.strikeID
                          select new { s.strikeLatitude, s.strikeLongitude, p.pictureFileName };

            foreach (var record in allPics)
            {
                listBox1.Items.Add(record.strikeLatitude + "\t\t" + record.strikeLongitude + "\t\t" + record.pictureFileName);
            }
        }

        private void btnFireStrikes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            StrikesDbDataContext db = new StrikesDbDataContext();

            var fireStrikes = from s in db.tblStrikes
                              join f in db.tblFires
                              on s.strikeDate equals f.fireDate
                              where s.strikeLongitude == f.fireLongitude &&
                                    s.strikeLatitude == f.fireLatitude
                              select f;

            foreach (var record in fireStrikes)
            {
                listBox1.Items.Add(record.fireDate + "\t\t" + record.fireArea);
            }
        }        
    }
}
