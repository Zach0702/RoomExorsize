using System;
using System.Collections.Generic;
using System.Text;

namespace RoomExorsize
{
    public class Kitchen /*: Fridge, DishWasher, Oven*/
    {
        public SonyFridge MyFridge { get; set; }
        public GasOven MyOven { get; set; }

        public SteamedDishWasher MyDishWasher { get; set; }
      

        public Kitchen(SonyFridge fridge, GasOven oven, SteamedDishWasher washer)
        {
            MyFridge = fridge;
            MyOven = oven;
            MyDishWasher = washer;
        }


        
    }
}
