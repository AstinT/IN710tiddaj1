﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorldFactoryPattern
{
    public class Australia : Continent
    {
        //Constructor
        public Australia(ListBox displayBox, Random rGen, int animalTypes, Graphics canvas)
            : base(displayBox, rGen, animalTypes, canvas)
        {
            //Setting factory to use
            animalFactory = new AustraliaAnimalFactory();
        }
    }
}
