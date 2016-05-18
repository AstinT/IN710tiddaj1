using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class SkeletonTorso : Torso
    {
        //Constructor
        public SkeletonTorso()
        {
            //Getting image
            image = Image.FromFile("Skeleton_1.png");
        }
    }
}
