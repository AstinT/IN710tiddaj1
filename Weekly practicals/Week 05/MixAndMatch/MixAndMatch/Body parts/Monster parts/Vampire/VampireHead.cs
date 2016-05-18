using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class VampireHead : Head
    {
        //Constructor
        public VampireHead()
        {
            //Getting image
            image = Image.FromFile("Vampire_0.png");
        }
    }
}
