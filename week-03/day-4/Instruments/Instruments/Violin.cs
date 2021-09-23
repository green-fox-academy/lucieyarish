using System;
namespace Instruments
{
    public class Violin : StringedInstrument
    {
        public Violin(int num) : this()
        {
            NumberOfStrings = num;
        }

        public Violin()
        {
            NumberOfStrings = 4;
            InstrumentSound = "Screech";
            InstrumentName = "Violin";
        }

        public override void Play()
        {
            Console.WriteLine($"Instrument name: {InstrumentName} with {NumberOfStrings} strings that makes the following sound: {InstrumentSound}");
        }
    }
}
