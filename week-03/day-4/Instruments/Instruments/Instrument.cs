using System;
namespace Instruments
{
    public abstract class Instrument
    {
        protected string name;

        public Instrument()
        {
        }

        public abstract void Play();
    }
}
