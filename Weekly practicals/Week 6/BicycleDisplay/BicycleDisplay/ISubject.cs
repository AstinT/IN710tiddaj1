﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleDisplay
{
    public interface ISubject
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
