using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class WitchLegs : Legs
    {
        //Constructor
        public WitchLegs()
        {
            //Getting image
            image = Image.FromFile("Witch_2.png");
        }
    }
}
