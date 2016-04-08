using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class ShipEventArgs : EventArgs
    {
        public int shipX { get; set; }
        public int shipY { get; set; }

        public ShipEventArgs(int currShipX, int currShipY)
        {
            shipX = currShipX;
            shipY = currShipY;
        }
    }
}
