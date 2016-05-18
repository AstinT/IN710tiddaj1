using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public class Weapon : IBattleMachine
    {
        protected String action;
        protected String weaponName;

        public String UseWeapon()
        {
            return "I " + action + " with my " + weaponName + "!";
        }
    }
}
