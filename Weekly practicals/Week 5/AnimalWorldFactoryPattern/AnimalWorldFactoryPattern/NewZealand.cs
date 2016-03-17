using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorldFactoryPattern
{
    //I HAVE JUST REALISED NEW ZEALAND IS NOT A CONTINENT!!!!!!!!!!!!! ohwell.................

    public class NewZealand : Continent
    {
        //Constructor
        public NewZealand(ListBox displayBox, Random rGen, int animalTypes, Graphics canvas)
            : base(displayBox, rGen, animalTypes, canvas)
        {
            //Setting factory to use
            animalFactory = new NewZealandAnimalFactory();
        }
    }
}
