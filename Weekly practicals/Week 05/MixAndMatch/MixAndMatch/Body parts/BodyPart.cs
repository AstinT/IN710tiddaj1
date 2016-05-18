using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    public class BodyPart
    {
        //Image to be displayed
        protected Image image;

        //Read only
        public Image Image
        {
            get { return image; }
        }
    }
}
