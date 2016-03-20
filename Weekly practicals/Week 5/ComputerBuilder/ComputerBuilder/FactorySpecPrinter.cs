using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerBuilder
{
    //This class handles all the printing
    public class FactorySpecPrinter
    {
        //Properties
        private IComputerFactory factoryMaker;
        private ListBox displayBox;

        //Constructor
        public FactorySpecPrinter(IComputerFactory factoryMaker, ListBox displayBox)
        {
            this.factoryMaker = factoryMaker;
            this.displayBox = displayBox;
        }       
    
        //Prints to the form
        public void printSpec()
        {
            Cpu currCpu = factoryMaker.buildCpu();
            Ram currRam = factoryMaker.buildRam();
            Gpu currGpu = factoryMaker.buildGpu();

            double totalPrice = currCpu.Price + currRam.Price + currGpu.Price;

            displayBox.Items.Clear();
            displayBox.Items.Add("Price\tComponent");
            displayBox.Items.Add("--------------------------------");

            displayBox.Items.Add(currCpu.ToString());
            displayBox.Items.Add(currRam.ToString());
            displayBox.Items.Add(currGpu.ToString());

            displayBox.Items.Add("--------------------------------");
            displayBox.Items.Add("Total Price: " + totalPrice.ToString());
        }
    }
}
