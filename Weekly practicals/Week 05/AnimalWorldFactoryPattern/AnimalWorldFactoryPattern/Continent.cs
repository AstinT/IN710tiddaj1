﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorldFactoryPattern
{
    public abstract class Continent
    {
        //Number of animals to create per Continent
        public const int ANIMAL_SIM_COUNT = 4;

        //Properties
        protected ListBox displayBox;
        protected Random rGen;
        protected int nAnimalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;

        //Constructor
        public Continent(ListBox displayBox, Random rGen, int nAnimalTypes, Graphics canvas)
        {
            this.displayBox = displayBox;
            this.rGen = rGen;
            this.nAnimalTypes = nAnimalTypes;
            this.canvas = canvas;
        }

        //Makes the animals, displays thier picture and adds ToString to listbox
        public void runSimulation()
        {
            Animal currentAnimal = null;

            for (int i = 0; i < ANIMAL_SIM_COUNT; i++)
            {
                int randAnimal = rGen.Next(nAnimalTypes);

                currentAnimal = animalFactory.createAnimal(randAnimal);

                displayBox.Items.Add(currentAnimal.ToString());
                canvas.DrawImage(currentAnimal.Image, 20, 20 + (i * 120), 150, 100);
            }
        }
    }
}
