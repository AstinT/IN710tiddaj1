﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class WitchTorso : Torso
    {
        //Constructor
        public WitchTorso()
        {
            //Getting image
            image = Image.FromFile("Witch_1.png");
        }
    }
}
