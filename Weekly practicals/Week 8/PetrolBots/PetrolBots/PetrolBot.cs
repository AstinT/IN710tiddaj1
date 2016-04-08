using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class PetrolBot
    {
        private Ship subject;
        private Graphics mainCanvas;

        public PetrolBot(Ship subject, Graphics mainCanvas)
        {
            this.subject = subject;
            this.mainCanvas = mainCanvas;

            System.EventHandler handler =
                new System.EventHandler(OutOfFuelEventHandler);

            subject.OutOfFuelEvent += handler;
        }

        public void OutOfFuelEventHandler(object subject, ShipEventArgs args)
        {

        }
    }
}
