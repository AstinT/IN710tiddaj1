using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorldFactoryPattern
{
    public class Animal
    {
        protected String name;
        protected String family;
        protected String food;
        protected Bitmap image { get; }

        public override String ToString()
        {
            String displayString;

            displayString = "I am " + name;
            displayString += ". I am a " + family;
            displayString += ". I eat " + food + ".";

            return displayString;
        }
    }
}
