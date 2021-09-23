using System;
namespace Instruments
{
    public abstract class Instrument
    {
        protected string InstrumentName;
        protected string InstrumentSound;

        public Instrument(string name, string sound)
        {
            InstrumentName = name;
            InstrumentSound = sound;
        }

        public Instrument()
        {

        }

        public abstract void Play();
    }
}
