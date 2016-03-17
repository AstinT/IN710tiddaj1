﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldFactoryPattern
{
    public class Kangaroo : Animal
    {
        //Constructor
        public Kangaroo()
        {
            name = "Kangaroo";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("kangaroo.jpg");
        }
    }
}
