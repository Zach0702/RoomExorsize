using System;
using System.Collections.Generic;
using System.Text;

namespace RoomExorsize
{
    public class Basement
    {
        public LGDryer myDryer { get; set; }

        public Basement(LGDryer userDryer)
        {
            myDryer = userDryer;

        }
     }
}
