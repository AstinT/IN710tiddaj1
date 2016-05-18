using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    public interface IObserver
    {
        void Update(int data1, int data2, int data3);
        void Display();
    }
}
