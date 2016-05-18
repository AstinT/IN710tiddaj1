using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    public abstract class Character
    {
        public String Name { get; set; }
        public IBattleMachine Weapon { get; set; }

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
