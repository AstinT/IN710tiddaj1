using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class THand
    {
        private TCard[] cards;
        private int privatePoints;
        private int numCards;

        public int points
        {
            get
            {
                return privatePoints;
            }

            set
            {
                privatePoints = value;
            }
        }

        public THand()
        {
            cards = new TCard[13];
        }

        public THand(TCard[] cardArray)
        {
            cards = new TCard[13];

            for (int i = 0; i < 13; i++)
            {
                cards[i] = cardArray[i];
            }
        }

        public void addCard(TCard newCard)
        {
            cards[numCards++] = newCard;
        }

        public int calcPoints()
        {
            privatePoints = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                switch (cards[i].number)
                {
                    case 14:
                        privatePoints += 4;
                        break;

                    case 11:
                        privatePoints += 1;
                        break;

                    case 12:
                        privatePoints += 2;
                        break;

                    case 13:
                        privatePoints += 3;
                        break;
                }
            }

            return privatePoints;
        }

        public void sortHand()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                TCard minCard = cards[i];
                int minPos = i;
                for (int j = i; j < cards.Length; j++)
                {
                    if (cards[j].suit < minCard.suit)
                    {
                        minCard = cards[j];
                        minPos = j;
                    }
                    else if (cards[j].suit == minCard.suit)
                    {
                        if (cards[j].number < minCard.number)
                        {
                            minCard = cards[j];
                            minPos = j;
                        }
                    }
                }
                TCard tempCard = cards[minPos];
                cards[minPos] = cards[i];
                cards[i] = tempCard;
            }
        }

        public override string ToString()
        {
            String spades = "S:\t";
            String hearts = "H:\t";
            String diamonds = "D:\t";
            String clubs = "C:\t";
            String myHand = "";

            sortHand();
            
            for (int i = 0; i < 13; i++)
            {
                int privateSuit = cards[i].suit;
                int privateNumber = cards[i].number;
                String number = "";

                switch (privateNumber)
                {
                    case 14:
                        number = "A";         
                        break;

                    case 11:
                        number = "J";
                        break;

                    case 12:
                        number = "Q";
                        break;

                    case 13:
                        number = "K";
                        break;

                    case 10:
                        number = "T";
                        break;

                    default:
                        number = Convert.ToString(privateNumber);
                        break;
                } 

                switch (privateSuit)
                {
                    case 0:
                        spades += number + " ";
                        break;

                    case 1:
                        clubs += number + " ";
                        break;

                    case 2:
                        diamonds += number + " ";
                        break;

                    case 3:
                        hearts += number + " ";
                        break;
                }                
            }

            myHand = spades + "\n" + hearts + "\n" + diamonds + "\n" + clubs + "\n";

            return myHand + "\r\n";
        }

    }
}
