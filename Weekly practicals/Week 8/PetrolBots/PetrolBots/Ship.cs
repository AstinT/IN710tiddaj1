using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBots
{
    public class Ship
    {
        //Delegate
        //MAKE A DELEGATE HERE!!!!!!!!!!

        //Events
        public event EventHandler FullOfFuelEvent;
        public event EventHandler OutOfFuelEvent;

        //Constants
        private const int SHIP_SIZE = 50;

        //Properties
        private Graphics mainCanvas;
        private int locX;
        private int locY;
        private Color shipColor;
        private int petrol;
        private EShipState state;

        public Ship(Graphics mainCanvas, int locX, int locY)
        {
            this.mainCanvas = mainCanvas;
            this.locX = locX;
            this.locY = locY;

            petrol = 100;
            state = EShipState.WANDERING;
        }

        public void DrawShip()
        {
            double petrolRatio = petrol / 100.0;
            double redValue = 255 * petrolRatio;
            shipColor = Color.FromArgb((int)redValue, 0, 0);
            SolidBrush shipBrush = new SolidBrush(shipColor);

            mainCanvas.FillRectangle(shipBrush, locX, locY, SHIP_SIZE, SHIP_SIZE);
        }

        public void OnFullOfFuelEvent()
        {

        }

        public void OnOutOfFuelEvent()
        {
            ShipEventArgs args = new ShipEventArgs(locX, locY);

            if (OutOfFuelEvent != null)
                OutOfFuelEvent(this, args);
        }

        public void MoveShip()
        {
            petrol = petrol - 5;

            if(petrol <= 0)
            {
                state = EShipState.REFUELING;

            }
            else
            {
                DrawShip();
            }
        }
    }
}
