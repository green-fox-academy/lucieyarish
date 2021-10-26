using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PrintColorDependencyInjection.Models
{
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        protected Printer Printer { get; }
        protected IColor Color { get; }

        public ConsoleLoggerMiddleware(Printer printer, IColor color)
        {
            Printer = printer;
            Color = color;
        }
        
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Printer.Log("Hi there");
            Color.PrintColor();

            return next(context);
        }
    }
}