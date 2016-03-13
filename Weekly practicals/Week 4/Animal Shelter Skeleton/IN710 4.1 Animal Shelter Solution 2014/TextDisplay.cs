using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    public class TextDisplay: IDisplay
    {
        //Properties
        private ListBox displayTextListBox;

        //Ctor
        public TextDisplay(ListBox listBox)
        {
            displayTextListBox = listBox;
        }

        //Adds all critters to ListBox from the critterList
        public void displayCritterList(List<Critter> critterList)
        {
            foreach(Critter critter in critterList)
            {
                //Adds the critter's species and name
                String strToAdd = critter.Species + ": " + critter.Name;
                displayTextListBox.Items.Add(strToAdd);
            }
        }

        //Clears all items from ListBox
        public void clearDisplay()
        {
            displayTextListBox.Items.Clear();
        }
    }
}
