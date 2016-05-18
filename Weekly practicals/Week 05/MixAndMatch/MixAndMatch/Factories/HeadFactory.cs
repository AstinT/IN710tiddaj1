using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    //Factory for building a monster head
    public class HeadFactory : IBodyPartFactory
    {
        //Creates a new head part and returns it
        public BodyPart createBodyPart(String characterString)
        {
            BodyPart newHeadPart = null;

            switch (characterString)
            {
                case "Fairy":
                    newHeadPart = new FairyHead();
                    break;
                case "Frankenstein":
                    newHeadPart = new FrankensteinHead();
                    break;
                case "Skeleton":
                    newHeadPart = new SkeletonHead();
                    break;
                case "Vampire":
                    newHeadPart = new VampireHead();
                    break;
                case "Werewolf":
                    newHeadPart = new WerewolfHead();
                    break;
                case "Witch":
                    newHeadPart = new WitchHead();
                    break;
            }

            return newHeadPart;
        }
    }
}
