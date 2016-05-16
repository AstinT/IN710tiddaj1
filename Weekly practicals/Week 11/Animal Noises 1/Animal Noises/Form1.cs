using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        //Fields
        private Animal mainAnimal;
        private Thread speakThread;

        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            mainAnimal = new Animal();
        }

        //Frog speaks
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            //New thread, passes it the animal speak method. Void method, no params.
            speakThread = new Thread(mainAnimal.speak);
            //Starts thread
            speakThread.Start();
        }

        //Pops message box
        private void btnWhat_Click(object sender, EventArgs e)
        {
            //Message
            MessageBox.Show("It is a frog");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Stops the thread
            speakThread.Abort();
        }
    }
}
