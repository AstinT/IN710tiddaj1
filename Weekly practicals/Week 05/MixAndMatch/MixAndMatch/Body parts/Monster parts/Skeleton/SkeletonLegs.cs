using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class SkeletonLegs : Legs
    {
        //Constructor
        public SkeletonLegs()
        {
            //Getting image
            image = Image.FromFile("Skeleton_2.png");
        }
    }
}
