using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorldFactoryPattern
{
    public class NorthAmerica : Continent
    {
        //Constructor
        public NorthAmerica(ListBox displayBox, Random rGen, int animalTypes, Graphics canvas)
            : base(displayBox, rGen, animalTypes, canvas)
        {
            //Setting factory to use
            animalFactory = new NorthAmericaAnimalFactory();
        }
    }
}
