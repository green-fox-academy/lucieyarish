using System;
namespace Instruments
{
    public class BassGuitar : StringedInstrument
    {
        public BassGuitar(int num) : this()
        {
            NumberOfStrings = num;
        }

        public BassGuitar()
        {
            NumberOfStrings = 4;
            InstrumentSound = "Duum-duum-duum";
            InstrumentName = "Bass Guitar";
        }

        public override void Play()
        {
            Console.WriteLine($"Instrument name: {InstrumentName} with {NumberOfStrings} strings that makes the following sound: {InstrumentSound}");
        }
    }
}
