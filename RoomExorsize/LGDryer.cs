namespace RoomExorsize
{
    public class LGDryer : Dryer
    {
        public void PutClothesInDryer(Clothes typeOfClothes)
        {
            System.Console.WriteLine($"Putting {typeOfClothes.TypeOfClothes} in LG Dryer");

        }
    }
}