using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public abstract class Character
    {
        protected String Name;
        protected IBattleMachine Weapon;

        public Character(String name)
        {
            Name = name;
        }

        public virtual String StateName()
        {
            return "My name is " + Name;
        }

        public virtual String UseWeapon()
        {
            return Weapon.UseWeapon();
        }

        public abstract String Declaim();
    }
}
