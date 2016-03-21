using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class WerewolfHead : Head
    {
        //Constructor
        public WerewolfHead()
        {
            //Getting image
            image = Image.FromFile("Werewolf_0.png");
        }        
    }
}
