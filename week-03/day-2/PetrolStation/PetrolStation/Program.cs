using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.GasAmountNow(10);
            car.GasCapacity(20);
            Station station = new Station();
            station.RefillCar(car);
        }
    }
}
