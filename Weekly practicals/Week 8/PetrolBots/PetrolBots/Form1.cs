using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBots
{
    public partial class Form1 : Form
    {
        private List<PetrolBot> botList;
        private List<Ship> shipList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PetrolBot bot1 = new PetrolBot();
            PetrolBot bot2 = new PetrolBot();
            PetrolBot bot3 = new PetrolBot();
            PetrolBot bot4 = new PetrolBot();
            PetrolBot bot5 = new PetrolBot();

            botList.Add(bot1);
            botList.Add(bot2);
            botList.Add(bot3);
            botList.Add(bot4);
            botList.Add(bot5);

            Ship ship1 = new Ship();
            Ship ship2 = new Ship();
            Ship ship3 = new Ship();
            Ship ship4 = new Ship();
            Ship ship5 = new Ship();

            shipList.Add(ship1);
            shipList.Add(ship2);
            shipList.Add(ship3);
            shipList.Add(ship4);
            shipList.Add(ship5);

            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
