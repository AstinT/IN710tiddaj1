﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    //Enum
    public enum EFireCategory { NONE, MINOR, SERIOUS, INFERNO };

    public class FireAlarmEventArgs : EventArgs
    {
        //Properties
        public EFireCategory FireCategory { get; set; }

        //Constructor
        public FireAlarmEventArgs(EFireCategory currentFireCategory)
        {
            FireCategory = currentFireCategory;
        }
    }
}
