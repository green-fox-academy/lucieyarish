using System;
using PrintColorDependencyInjection.Models;

namespace PrintColorDependencyInjection
{
    public class GreenColor : IColor
    {
        protected Printer Printer { get; }

        public GreenColor(Printer printer)
        {
            Printer = printer;
        }
        public void PrintColor()
        {
            Printer.Log("It is green in color...");
        }
    }
}