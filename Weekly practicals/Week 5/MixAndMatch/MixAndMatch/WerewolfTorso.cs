using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class WerewolfTorso : Torso
    {
        public WerewolfTorso()
        {
            image = Image.FromFile("Werewolf_1.png");
        }
    }
}
