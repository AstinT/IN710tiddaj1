using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    public class TextDisplay: IDisplay
    {
        private ListBox displayTextListBox;

        public TextDisplay(ListBox listBox)
        {
            displayTextListBox = listBox;
        }

        public void displayCritterList(List<Critter> critterList)
        {
            foreach(Critter critter in critterList)
            {
                displayTextListBox.Items.Add
            }
        }

        public void clearDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
