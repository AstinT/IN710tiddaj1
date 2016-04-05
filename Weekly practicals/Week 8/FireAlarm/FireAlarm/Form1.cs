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
        FireAlarmSubject subject;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new FireAlarmSubject();

            new InstructionsObserver(subject);
            new BeepObserver(subject);
        }

        private void btnFireAlarm_Click(object sender, EventArgs e)
        {
            EFireCategory currFireCategory = EFireCategory.NONE;

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

            if (currFireCategory != EFireCategory.NONE)
                subject.OnFireEvent(currFireCategory);
        }        
    }
}
