using System;
namespace Flyable
{
    public abstract class Vehicle : IFlyable
    {
        string Name;
        int Age;
        string Type;

        public Vehicle(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        public Vehicle()
        {

        }

        public virtual void Land()
        {
            
        }

        public virtual void Fly()
        {
            
        }

        public virtual void TakeOff()
        {
            
        }
    }
}
