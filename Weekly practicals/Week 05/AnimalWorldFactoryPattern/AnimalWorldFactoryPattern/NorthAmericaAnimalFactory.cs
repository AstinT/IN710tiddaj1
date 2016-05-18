using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldFactoryPattern
{
    public class NorthAmericaAnimalFactory : IAnimalFactory
    {
        //Interface method
        //Creates new animal and returns it
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            //All possible animals from North America
            switch (animalCode)
            {
                case 0:
                    newAnimal = new Bison();
                    break;
                case 1:
                    newAnimal = new Eagle();
                    break;
                case 2:
                    newAnimal = new Wolf();
                    break;
            }
            return newAnimal;
        }
    }
}
