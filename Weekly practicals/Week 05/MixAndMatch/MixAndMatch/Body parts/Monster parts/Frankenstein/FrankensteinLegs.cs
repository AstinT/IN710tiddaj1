using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class FrankensteinLegs : Legs
    {
        //Constructor
        public FrankensteinLegs()
        {
            //Getting image
            image = Image.FromFile("Frankenstein_2.png");
        }
    }
}
