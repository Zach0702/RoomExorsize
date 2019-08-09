using System;

namespace RoomExorsize
{
    class Program
    {
        static void Main(string[] args)
        {
            var fridge = new SonyFridge();
            var oven = new GasOven();
            var dishwasher = new SteamedDishWasher();
            var kitchen = new Kitchen(fridge, oven, dishwasher);
            var lunch = new Food("Fish");
            var basement = new Basement(new LGDryer());
            var clothes = new Clothes("T-shirt");

            kitchen.MyFridge.PutFoodInFridge(lunch);
            kitchen.MyOven.PutFoodInOven(lunch);
            basement.myDryer.PutClothesInDryer(clothes);
            
            
        }
    }
}
