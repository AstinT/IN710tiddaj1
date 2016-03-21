using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixAndMatch
{
    public class TorsoFactory : IBodyPartFactory
    {
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
