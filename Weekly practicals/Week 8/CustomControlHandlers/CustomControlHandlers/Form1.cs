using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandlers
{
    public partial class Form1 : Form
    {
        //Properties
        Random rand;
        int randCodeNum1;
        int randCodeNum2;

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Generate randoms
            rand = new Random();
            randCodeNum1 = rand.Next(1, 100);
            randCodeNum2 = rand.Next(1, 100);

            //Two instances of CustomHandlerObserver, Passes a reference to the button and a random.
            new CustomHandlerObserver(btnTestHandlers, randCodeNum1);
            new CustomHandlerObserver(btnTestHandlers, randCodeNum2);
        }

        //Button click method
        private void btnTestHandlers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the forms handler.");
        }
    }
}
