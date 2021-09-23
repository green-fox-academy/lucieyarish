using System;
namespace Instruments
{
    public abstract class StringedInstrument : Instrument
    {
        protected int NumberOfStrings { get; set; }

        public StringedInstrument(string name, int num, string sound) : base(name, sound)
        {
            NumberOfStrings = num;  
        }

        public StringedInstrument()
        {

        }

        public virtual void Sound()
        {

        }

        public override void Play()
        {
            Sound();
        }
    }
}
