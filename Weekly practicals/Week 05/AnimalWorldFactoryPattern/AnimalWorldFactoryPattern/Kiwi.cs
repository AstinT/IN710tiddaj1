using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldFactoryPattern
{
    public class Kiwi : Animal
    {
        //Constructor
        public Kiwi()
        {
            name = "Kiwi";
            family = "Omnivore";
            food = "Berries, insects and roots";
            image = new Bitmap("kiwi.jpg");
        }
    }
}
