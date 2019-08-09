using System;
using System.Collections.Generic;
using System.Text;

namespace RoomExorsize
{
    public class GasOven : Oven
    {
        public void PutFoodInOven(Food food)
        {
            Console.WriteLine($"Putting {food.TypeOfFood} in oven");
        }
    }
}
