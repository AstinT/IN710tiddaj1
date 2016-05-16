using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Fields
        private List<Animal> animalList;
        private List<Thread> threadList;
        private String locker;

        private void Form1_Load(object sender, EventArgs e)
        {
            //String to be passed to all animals so we can lock
            locker = "locker";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //New lists
            animalList = new List<Animal>();
            threadList = new List<Thread>();

            //Adding animals
            //Passing the lock string and wav file name
            animalList.Add(new Animal(locker, "frog.wav"));
            animalList.Add(new Animal(locker, "duck.wav"));
            animalList.Add(new Animal(locker, "meow.wav"));

            //Creates list of Threads with each animals speak method
            for (int i = 0; i < animalList.Count; i++)
                threadList.Add(new Thread(animalList[i].speak)); 
            
            //Starts all Threads
            for (int i = 0; i < animalList.Count; i++)
                threadList[i].Start();
        }

        //Stops all Threads
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < animalList.Count; i++)
                //Kills
                threadList[i].Abort();
        }
    }
}
