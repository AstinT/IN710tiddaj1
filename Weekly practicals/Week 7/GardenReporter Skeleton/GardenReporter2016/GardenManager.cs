using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public class GardenManager
    {
        //Delegate
        public delegate String GardenDelegate(Garden garden);
        GardenDelegate gardenDelegate;

        //Properties
        List<Garden> gardenList;
        ListBox displayBox;

        //Constructor
        public GardenManager(ListBox displayBox)
        {
            gardenList = new List<Garden>();
            this.displayBox = displayBox;
            gardenDelegate = null;
        }

        //Methods
        public void AddGarden(Garden newGarden)
        {
            gardenList.Add(newGarden);
        }

        public void ProcessGardens()
        {
            foreach(Garden currGarden in gardenList)
            {

            }
        }

        public String CalculateGardenArea(Garden garden)
        {

        }

        public String CalculateGardenCharges(Garden garden)
        {

        }
    }
}
