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
        public delegate void OutOfFuelDelegate(object o, ShipEventArgs args);

        //Events
        public event OutOfFuelDelegate OutOfFuelEvent;
        public event EventHandler FullOfFuelEvent;        

        //Constants
        private const int SHIP_SIZE = 50;

        //Fields
        private Graphics mainCanvas;
        private Point position;
        private Point velocity;
        private Color shipColor;
        private int petrol;
        private EShipState state;
        private Size clientSize;

        //Constructor
        public Ship(Graphics mainCanvas, Size clientSize, Point velocity)
        {
            this.mainCanvas = mainCanvas;
            this.clientSize = clientSize;
            this.velocity = velocity;

            position = new Point(0, 0);
            petrol = 100;
            state = EShipState.WANDERING;
        }

        public void DrawShip()
        {
            //Changing colour code
            double petrolRatio = petrol / 100.0;
            double redValue = 255 * petrolRatio;
            shipColor = Color.FromArgb((int)redValue, 0, 0);
            SolidBrush shipBrush = new SolidBrush(shipColor);

            mainCanvas.FillRectangle(shipBrush, position.X, position.Y, SHIP_SIZE, SHIP_SIZE);
        }

        public void OnOutOfFuelEvent()
        {
            ShipEventArgs args = new ShipEventArgs(position.X, position.Y);

            //if not empty
            if (OutOfFuelEvent != null)
                OutOfFuelEvent(this, args);
        }

        public void OnFullOfFuelEvent()
        {
            EventArgs args = new EventArgs();

            //if not empty
            if (FullOfFuelEvent != null)
                FullOfFuelEvent(this, args);
        }

        public void Refuel()
        {            
            if(state == EShipState.REFUELING)
            {
                if(petrol < 100)
                {
                    petrol += 1;
                    DrawShip();
                    OnOutOfFuelEvent();
                }
                else
                {
                    state = EShipState.WANDERING;
                    OnFullOfFuelEvent();
                }     
            }
        }

        public void MoveShip()
        {
            if((petrol > 0) && (state == EShipState.WANDERING))
            {
                //Move ship
                position.X += velocity.X;
                position.Y += velocity.Y;

                if ((position.X + SHIP_SIZE) >= (clientSize.Width)) //Right
                {
                    velocity.X *= -1;
                }
                else if (position.X <= 0) //Left
                {
                    velocity.X *= -1;
                }
                else if ((position.Y + SHIP_SIZE) >= (clientSize.Height - 30)) //Bottom
                {
                    velocity.Y *= -1;
                }
                else if (position.Y <= 0) //Top
                {
                    velocity.Y *= -1;
                }

                //Use petrol
                petrol -= 1;
            }
            else
            {
                state = EShipState.REFUELING;
            }
        }

        //Move and draw
        public void Animate()
        {
            if(state == EShipState.WANDERING)
            {
                MoveShip();
                DrawShip();
            }
            else
            {
                Refuel();
            }            
        }
    }
}
