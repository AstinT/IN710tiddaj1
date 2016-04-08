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
        private Graphics mainCanvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Height = 600;
            Width = 600;

            mainCanvas = CreateGraphics();

            shipList = new List<Ship>();
            botList = new List<PetrolBot>();

            Ship ship1 = new Ship(mainCanvas, 0, 0);
            shipList.Add(ship1);

            PetrolBot bot1 = new PetrolBot(ship1, mainCanvas);
            botList.Add(bot1);

            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach(Ship currShip in shipList)
            {
                mainCanvas.Clear(Color.White);
                currShip.MoveShip();
            }
        }
    }
}
