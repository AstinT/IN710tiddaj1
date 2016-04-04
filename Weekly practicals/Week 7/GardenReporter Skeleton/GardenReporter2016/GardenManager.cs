using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    //Delegate
    public delegate String GardenDelegate(Garden garden);

    public class GardenManager
    {
        //Properties
        List<Garden> gardenList;
        ListBox displayBox;

        //Constructor
        public GardenManager(ListBox displayBox)
        {
            gardenList = new List<Garden>();
            this.displayBox = displayBox;
        }

        //Methods
        public void AddGarden(Garden newGarden)
        {
            gardenList.Add(newGarden);
        }

        //Displays different information depending on what method it is passed
        public void ProcessGardens(GardenDelegate operation)
        {
            foreach(Garden currGarden in gardenList)
            {
                displayBox.Items.Add(operation(currGarden));
            }
        }

        public String DisplayGardenArea(Garden garden)
        {
            String reportString = String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetArea());
            return reportString;
        }

        public String DisplayGardenCharges(Garden garden)
        {
            String reportString = String.Format("{0,-14}:{1,8:f2}", garden.OwnerName, garden.GetAccountBalance());
            return reportString;
        }
    }
}
