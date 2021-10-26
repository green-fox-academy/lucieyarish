using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HelloDependencyInjection.Models
{
    public class ConsoleLoggerMiddleware : IMiddleware
    {
        protected Printer Printer { get; }

        public ConsoleLoggerMiddleware(Printer printer)
        {
            Printer = printer;
        }
        
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Printer.Log("Hi there");

            return next(context);
        }
    }
}