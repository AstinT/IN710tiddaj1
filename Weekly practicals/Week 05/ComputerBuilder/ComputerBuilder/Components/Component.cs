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

        //Read only for displaying the price
        public int Price
        {
            get {return price;}
        }

        //Concats the price and name of the component, returns string
        public override string ToString()
        {
            String displayString;

            displayString = price + "\t" + name;

            return displayString;
        }
    }
}
