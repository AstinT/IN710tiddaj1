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
        public const int ANIMAL_TYPES = 3;

        Random rGen;
        Graphics canvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rGen = new Random();
            canvas = this.CreateGraphics();
        }

        private void btnNorthAmerica_Click(object sender, EventArgs e)
        {
            lbDisplayBox.Items.Clear();
            Continent northAmerica = new NorthAmerica(lbDisplayBox, rGen, ANIMAL_TYPES, canvas);
            northAmerica.runSimulation();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            lbDisplayBox.Items.Clear();
            Continent australia = new Australia(lbDisplayBox, rGen, ANIMAL_TYPES, canvas);
            australia.runSimulation();
        }
    }
}
