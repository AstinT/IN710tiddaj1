﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldFactoryPattern
{
    public class Crocodile : Animal
    {
        //Constructor
        public Crocodile()
        {
            name = "Crocodile";
            family = "Carnivore";
            food = "Fish";
            image = new Bitmap("crocodile.jpg");
        }
    }
}
