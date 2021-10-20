using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FirstWebApp
{
    public class Startup
    {
        //Here you say what your app is capable of doing (e.g. specify database address, or define authentication
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        //Request-response pipeline in which you define what's gonna happen in between the request and response
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Here request enters
            
            app.UseDeveloperExceptionPage();
            
            app.UseRouting();
            //add css (static file)
            // app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}