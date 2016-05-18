using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldFactoryPattern
{
    public class AustraliaAnimalFactory : IAnimalFactory
    {
        //Interface method
        //Creates new animal and returns it
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            //All possible animals from Australia
            switch (animalCode)
            {
                case 0:
                    newAnimal = new Kangaroo();
                    break;
                case 1:
                    newAnimal = new Crocodile();
                    break;
                case 2:
                    newAnimal = new Koala();
                    break;
            }
            return newAnimal;
        }
    }
}
