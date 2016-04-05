using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        //Properties
        FireAlarmSubject subject;

        public Form1()
        {
            InitializeComponent();
        }

        //Creates instances of subject and observers
        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new FireAlarmSubject();

            new InstructionsObserver(subject);
            new BeepObserver(subject);
        }

        //Button click method
        private void btnFireAlarm_Click(object sender, EventArgs e)
        {
            //Set currFireCategory to none. Kind of like null.
            EFireCategory currFireCategory = EFireCategory.NONE;

            //Checks what radio button is selected and sets appropriate enum
            if (rbMinor.Checked)
            {
                currFireCategory = EFireCategory.MINOR;
            }
            else if (rbSerious.Checked)
            {
                currFireCategory = EFireCategory.SERIOUS;
            }
            else if (rbInferno.Checked)
            {
                currFireCategory = EFireCategory.INFERNO;
            }
            else
                MessageBox.Show("Please select a radio button.");

            //Checks if currFireCategory has been set
            if (currFireCategory != EFireCategory.NONE)
                //Triggers OnFireEventMethod and passes currFireCategory
                subject.OnFireEvent(currFireCategory);
        }        
    }
}
