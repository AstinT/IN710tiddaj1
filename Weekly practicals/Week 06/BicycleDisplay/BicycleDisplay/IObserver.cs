using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleDisplay
{
    //Interface for observer classes
    public interface IObserver
    {
        void Update(int data);
        void Display();
    }
}
