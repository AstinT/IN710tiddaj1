using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorldFactoryPattern
{
    public partial class Form1 : Form
    {
        //Number of animals significant to a country
        public const int ANIMAL_TYPES = 3;

        //Properties to be passed to the contients
        Random rGen;
        Graphics canvas;

        public Form1()
        {
            InitializeComponent();
        }

        //Called when Form starts
        private void Form1_Load(object sender, EventArgs e)
        {
            rGen = new Random();
            canvas = this.CreateGraphics();
        }

        //When clicked, Makes an instance of NorthAmerica
        private void btnNorthAmerica_Click(object sender, EventArgs e)
        {
            lbDisplayBox.Items.Clear();
            Continent northAmerica = new NorthAmerica(lbDisplayBox, rGen, ANIMAL_TYPES, canvas);
            northAmerica.runSimulation();
        }

        //When clicked, Makes an instance of Australia
        private void btnAustralia_Click(object sender, EventArgs e)
        {
            lbDisplayBox.Items.Clear();
            Continent australia = new Australia(lbDisplayBox, rGen, ANIMAL_TYPES, canvas);
            australia.runSimulation();
        }

        //When clicked, Makes an instance of New Zealand
        private void btnNewZealand_Click(object sender, EventArgs e)
        {
            lbDisplayBox.Items.Clear();
            Continent newZealand = new NewZealand(lbDisplayBox, rGen, ANIMAL_TYPES, canvas);
            newZealand.runSimulation();
        }
    }
}
