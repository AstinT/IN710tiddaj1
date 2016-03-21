using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    //Factory for building a monster legs
    public class LegsFactory : IBodyPartFactory
    {
        //Creates a new legs part and returns it
        public BodyPart createBodyPart(String characterString)
        {
            BodyPart newHeadPart = null;

            switch (characterString)
            {
                case "Fairy":
                    newHeadPart = new FairyLegs();
                    break;
                case "Frankenstein":
                    newHeadPart = new FrankensteinLegs();
                    break;
                case "Skeleton":
                    newHeadPart = new SkeletonLegs();
                    break;
                case "Vampire":
                    newHeadPart = new VampireLegs();
                    break;
                case "Werewolf":
                    newHeadPart = new WerewolfLegs();
                    break;
                case "Witch":
                    newHeadPart = new WitchLegs();
                    break;
            }

            return newHeadPart;
        }
    }
}
