using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Form data fields
        IComputerFactory currComputerFactory;

        //Form methods
        private void btnPrintSpec_Click(object sender, EventArgs e)
        {
            if (rbGaming.Checked)
                currComputerFactory = new GameComputerFactory();
            else if (rbBusiness.Checked)
                currComputerFactory = new BusinessComputerFactory();
            else
                currComputerFactory = new MultimediaComputerFactory();

            FactorySpecPrinter currSpecPrinter = new FactorySpecPrinter(currComputerFactory, lbDisplayBox);
            currSpecPrinter.printSpec();
        }
    }
}
