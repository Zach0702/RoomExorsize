using System;
using System.Collections.Generic;
using System.Text;

namespace RoomExorsize
{
    public class SonyFridge : Fridge
    {
        public void PutFoodInFridge(Food typeOfFood)
        {
            Console.WriteLine($"Storing {typeOfFood.TypeOfFood} in sony fridge");
        }
    }
}
