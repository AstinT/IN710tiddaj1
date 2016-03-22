using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleDisplay
{
    public interface IObserver
    {
        void Update(int data);
        void Display();
    }
}
