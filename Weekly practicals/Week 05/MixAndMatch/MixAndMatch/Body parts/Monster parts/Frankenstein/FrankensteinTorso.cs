using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class FrankensteinTorso : Torso
    {
        //Constructor
        public FrankensteinTorso()
        {
            //Getting image
            image = Image.FromFile("Frankenstein_1.png");
        }
    }
}
