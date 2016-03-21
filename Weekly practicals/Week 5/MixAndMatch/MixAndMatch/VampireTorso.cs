using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class VampireTorso : Torso
    {
       //Constructor
       public VampireTorso()
        {
            //Getting image
            image = Image.FromFile("Vampire_1.png");
        }
    }
}
