using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class WerewolfLegs : Legs
    {
        public WerewolfLegs()
        {
            image = Image.FromFile("Werewolf_2.png");
        }
    }
}
