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

        public virtual String StateName()
        {
            return "My name is " + Name;
        }

        public abstract String Declaim();
    }
}
