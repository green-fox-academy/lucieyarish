using System;
namespace PetrolStation
{
    public class Station
    {
        public int gasStorage = 100;
        public void RefillCar(Car car)
        {
            int refillAmount = car.Capacity - car.gasAmount;
            Console.WriteLine(refillAmount);
            if (gasStorage <= refillAmount)
            {
                car.gasAmount += gasStorage;
                gasStorage = 0;
            }
            else
            {
                car.gasAmount += refillAmount;
                gasStorage -= refillAmount;
            }
        }
    }
}
