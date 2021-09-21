using System;
namespace PetrolStation
{
    public class Car
    {
        public int gasAmount = 0;
        public int Capacity = 0;

        public void GasAmountNow(int liters)
        {
            this.gasAmount = liters;
        }

        public void GasCapacity(int capacity)
        {
            this.Capacity = capacity;
        }
    }
}
