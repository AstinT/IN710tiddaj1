using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class VampireLegs : Legs
    {
        public VampireLegs()
        {
            image = Image.FromFile("Vampire_2.png");
        }
    }
}
