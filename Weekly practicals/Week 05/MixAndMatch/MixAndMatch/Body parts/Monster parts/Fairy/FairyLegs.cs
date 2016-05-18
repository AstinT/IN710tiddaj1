using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class FairyLegs : Legs
    {
        //Constructor
        public FairyLegs()
        {
            //Getting image
            image = Image.FromFile("Fairy_2.png");
        }
    }
}
