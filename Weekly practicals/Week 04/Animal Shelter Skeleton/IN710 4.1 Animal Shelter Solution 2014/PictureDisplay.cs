using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    public class PictureDisplay: IDisplay
    {
        //Properties
        private List<PictureBox> pictureBoxAnimalList;

        //Ctor
        public PictureDisplay(List<PictureBox> pictureBoxList)
        {
            pictureBoxAnimalList = pictureBoxList;
        }

        //All critters in critterList get there photo added to the picture boxes in pictureBoxAnimalList
        public void displayCritterList(List<Critter> critterList)
        {
            for (int i = 0; i < critterList.Count; i++)
            {
                Image animalImage = Image.FromFile(critterList[i].ImageFileName);
                pictureBoxAnimalList[i].Image = animalImage;
            }
        }

        //Clears what the pictureBoxs are holding
        public void clearDisplay()
        {
            for (int i = 0; i < pictureBoxAnimalList.Count; i++)
            {
                //Setting Image to null clears image
                pictureBoxAnimalList[i].Image = null;
            }
        }
    }
}
