using System;
using PrintColorDependencyInjection.Models;

namespace PrintColorDependencyInjection
{
    public class RedColor : IColor
    {
        protected Printer Printer { get; }

        public RedColor(Printer printer)
        {
            Printer = printer;
        }
        public void PrintColor()
        {
            Printer.Log("It is red in color...");
        }
    }
}