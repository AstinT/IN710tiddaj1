using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorldFactoryPattern
{
    public class NewZealand : Continent
    {
        public NewZealand(ListBox displayBox, Random rGen, int animalTypes, Graphics canvas)
            : base(displayBox, rGen, animalTypes, canvas)
        {
            animalFactory = new NewZealandAnimalFactory();
        }
    }
}
