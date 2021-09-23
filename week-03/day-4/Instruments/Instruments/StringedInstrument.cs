using System;
namespace Instruments
{
    public abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        public StringedInstrument()
        {
           
        }

        public void Sound()
        {

        }

        public override void Play()
        {
            Sound();
        }
    }
}
