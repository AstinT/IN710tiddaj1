using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class FrankensteinTorso : Torso
    {
        public FrankensteinTorso()
        {
            image = Image.FromFile("Frankenstein_1.png");
        }
    }
}
