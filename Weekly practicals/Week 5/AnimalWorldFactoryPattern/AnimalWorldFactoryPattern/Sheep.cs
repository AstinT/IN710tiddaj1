using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldFactoryPattern
{
    public class Sheep : Animal
    {
        //Constructor
        public Sheep()
        {
            name = "Sheep";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("sheep.jpg");
        }
    }
}
