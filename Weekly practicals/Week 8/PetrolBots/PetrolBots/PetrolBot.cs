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
        //Constants
        private const int BOT_INITIAL_X = 100;
        private const int BOT_INITIAL_Y = 100;
        private const int BASE_HEIGHT = 30;

        //Fields
        private Ship subject;
        private Graphics mainCanvas;
        private Size clientSize;
        private Point basePosition;
        private Point currentPosition;
        private Color botColor;

        public PetrolBot(Ship subject, Graphics mainCanvas, Size clientSize, Point basePosition, Color botColor)
        {
            this.subject = subject;
            this.mainCanvas = mainCanvas;
            this.clientSize = clientSize;
            this.basePosition = basePosition;
            this.botColor = botColor;
            currentPosition = basePosition;

            Ship.OutOfFuelDelegate outOfFuelHandler =
                new Ship.OutOfFuelDelegate(OutOfFuelEventHandler);

            System.EventHandler fullOfFuelHandler =
                new System.EventHandler(FullOfFuelEventHandler);

            //Observer add its self to events
            subject.OutOfFuelEvent += outOfFuelHandler;
            subject.FullOfFuelEvent += fullOfFuelHandler;
        }

        public void OutOfFuelEventHandler(object subject, ShipEventArgs args)
        {
            //Go to ship position
            currentPosition.X = args.shipX + 20;
            currentPosition.Y = args.shipY + 20;
            Draw();
        }

        public void FullOfFuelEventHandler(object subject, EventArgs args)
        {
            //Return to base
            currentPosition.X = basePosition.X;
            currentPosition.Y = basePosition.Y;
            Draw();
        }

        public void Draw()
        {
            //Make a balck rectangle for the petrol bot base
            SolidBrush baseBrush = new SolidBrush(Color.Black);
            mainCanvas.FillRectangle(baseBrush, 0, (clientSize.Height - BASE_HEIGHT), clientSize.Width, BASE_HEIGHT);

            //Draw bot
            SolidBrush petrolBotBrush = new SolidBrush(botColor);
            mainCanvas.FillEllipse(petrolBotBrush, currentPosition.X, currentPosition.Y, 10, 10);
        }
    }
}
