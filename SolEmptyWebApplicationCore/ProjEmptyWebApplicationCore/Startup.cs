using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjEmptyWebApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjEmptyWebApplicationCore
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(_config.GetConnectionString("EmployeeDBConnection")));

            services.AddRazorPages();

            services.AddControllersWithViews().AddXmlSerializerFormatters();

            services.AddScoped<IEmployeeRepository, SQLEmployeeRepository>();

            //services.AddScoped<IEmployeeRepository, MockEmployeeRepository>();

            //services.AddTransient<IEmployeeRepository, MockEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            } else if (env.IsStaging() || env.IsProduction() || env.IsEnvironment("UAT"))
            {
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }

            //app.UseStatusCodePages();
            //app.UseStatusCodePagesWithRedirects("/Error/{0}");
            //app.UseStatusCodePagesWithReExecute("/Error/{0}");

            app.UseStaticFiles();  

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();

                //endpoints.MapGet("/", async context =>
                //{
                //    // await context.Response.WriteAsync("Hosting Enviroment: " + env.EnvironmentName);
                //    await context.Response.WriteAsync("Hello World!");
                //});


            });
        }
    }
}
