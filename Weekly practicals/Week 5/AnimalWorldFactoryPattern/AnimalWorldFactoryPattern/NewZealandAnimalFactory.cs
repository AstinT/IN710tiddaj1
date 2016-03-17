using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldFactoryPattern
{
    public class NewZealandAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Sheep();
                    break;
                case 1:
                    newAnimal = new Kiwi();
                    break;
                case 2:
                    newAnimal = new Kea();
                    break;
            }
            return newAnimal;
        }
    }
}
