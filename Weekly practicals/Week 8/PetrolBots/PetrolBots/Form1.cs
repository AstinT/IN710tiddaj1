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
        private const int BASE_HEIGHT = 30;

        //Fields
        private List<PetrolBot> petrolBotList;
        private List<Ship> shipList;
        private Graphics mainCanvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form size
            Height = 600;
            Width = 600;

            //Creates graphics
            mainCanvas = CreateGraphics();

            //List for ships and petrol bots
            shipList = new List<Ship>();
            petrolBotList = new List<PetrolBot>();

            //Creates petrolbot and adds to list
            Ship ship1 = new Ship(mainCanvas, ClientSize, new Point(10, 8));
            shipList.Add(ship1);

            Ship ship2 = new Ship(mainCanvas, ClientSize, new Point(4, 8));
            shipList.Add(ship2);

            Ship ship3 = new Ship(mainCanvas, ClientSize, new Point(6, 8));
            shipList.Add(ship3);

            //Creates petrolbot and adds to list
            PetrolBot petrolBot1 = new PetrolBot(ship1, mainCanvas, ClientSize, new Point(10, 540), Color.Yellow);
            petrolBotList.Add(petrolBot1);           

            PetrolBot petrolBot2 = new PetrolBot(ship2, mainCanvas, ClientSize, new Point(30, 540), Color.Green);
            petrolBotList.Add(petrolBot2);           

            PetrolBot petrolBot3 = new PetrolBot(ship3, mainCanvas, ClientSize, new Point(50, 540), Color.Blue);
            petrolBotList.Add(petrolBot3);

            //Starts timer
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Clears canvas
            mainCanvas.Clear(Color.LightGray);

            //Make a balck rectangle for the petrol bot base
            SolidBrush baseBrush = new SolidBrush(Color.Black);
            mainCanvas.FillRectangle(baseBrush, 0, (ClientSize.Height - BASE_HEIGHT), ClientSize.Width, BASE_HEIGHT);

            for (int i = 0; i < shipList.Count; i++)
            {
                shipList[i].Animate();
                petrolBotList[i].Draw();
            }
        }
    }
}