﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation
{
    //Interface for subject class
    public interface ISubject
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
