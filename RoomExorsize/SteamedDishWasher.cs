using System;
using System.Collections.Generic;
using System.Text;

namespace RoomExorsize
{
    public class SteamedDishWasher : DishWasher
    {
        public void LoadDishWasher(Utensil typeOfUtensil)
        {
            Console.WriteLine($"Putting {typeOfUtensil.TypeOfUtensil} in the dishwasher");
        }
    }
}
