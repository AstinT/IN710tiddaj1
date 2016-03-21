using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class FairyTorso : Torso
    {
        //Constructor
        public FairyTorso()
        {
            //Getting image
            image = Image.FromFile("Fairy_1.png");
        }
    }
}
