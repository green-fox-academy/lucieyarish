using System;
namespace Instruments
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int num) : this()
        {
            NumberOfStrings = num;
        }

        public ElectricGuitar()
        {
            NumberOfStrings = 6;
            InstrumentSound = "Twang";
            InstrumentName = "Electric Guitar";
        }

        public override void Play()
        {
            Console.WriteLine($"Instrument name: {InstrumentName} with {NumberOfStrings} strings that makes the following sound: {InstrumentSound}");
        }
    }
}
