using System;
using PrintColorDependencyInjection.Models;

namespace PrintColorDependencyInjection
{
    public class BlueColor
    {
        protected Printer Printer { get; }

        public BlueColor(Printer printer)
        {
            Printer = printer;
        }
        public void PrintColor()
        {
            Printer.Log("It is red in color...");
        }
    }
}