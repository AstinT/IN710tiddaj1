using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork
{
    public interface IObserver
    {
        void Update(String newStatus);
        void Display();
    }
}
