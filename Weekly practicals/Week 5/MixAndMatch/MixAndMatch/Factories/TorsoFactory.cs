using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    //Factory for building a monster torso
    public class TorsoFactory : IBodyPartFactory
    {
        //Creates a new torso part and returns it
        public BodyPart createBodyPart(String characterString)
        {
            BodyPart newTorsoPart = null;

            switch (characterString)
            {
                case "Fairy":
                    newTorsoPart = new FairyTorso();
                    break;
                case "Frankenstein":
                    newTorsoPart = new FrankensteinTorso();
                    break;
                case "Skeleton":
                    newTorsoPart = new SkeletonTorso();
                    break;
                case "Vampire":
                    newTorsoPart = new VampireTorso();
                    break;
                case "Werewolf":
                    newTorsoPart = new WerewolfTorso();
                    break;
                case "Witch":
                    newTorsoPart = new WitchTorso();
                    break;
            }

            return newTorsoPart;
        }
    }
}
