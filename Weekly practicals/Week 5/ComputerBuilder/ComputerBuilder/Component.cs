using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerBuilder
{
    public class Component
    {
        //Properties
        protected int price;
        protected String name;

        public int Price
        {
            get {return price;}
        }

        public override string ToString()
        {
            String displayString;

            displayString = price + "\t" + name;

            return displayString;
        }
    }
}
