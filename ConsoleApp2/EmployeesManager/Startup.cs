using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManager
{
    public class Startup
    {
        private readonly IConfiguration configuration;
      
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
         
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc(options=>options.EnableEndpointRouting=false);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {

           
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions exceptionPageOptions = new DeveloperExceptionPageOptions()
                { SourceCodeLineCount = 10};
                app.UseDeveloperExceptionPage(exceptionPageOptions);
            }
            //DefaultFilesOptions options = new DefaultFilesOptions();
            //options.DefaultFileNames.Clear();
            //options.DefaultFileNames.Add("foo.html");
            //app.UseDefaultFiles(options);

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            //app.Use(async (context, next) =>
            //{
            //    logger.LogInformation("MW1: Incoming Request");
            //    await next();
            //    logger.LogInformation("MW1: Outgoing Response");
            //});
            //app.Use(async (context, next) =>
            //{
            //    logger.LogInformation("MW2: Incoming Request");
            //    await next();
            //    logger.LogInformation("MW2: Outgoing Response");
            //});

            app.Run(async (context) =>
            {
                //throw new Exception("Some error during processing");
                await context.Response.WriteAsync($"Your Working Enviorment is {env.EnvironmentName}");

                //logger.LogInformation("MW3: Accespting Request and Giving Response");
            });

        }
    }
}

/*
 app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync
                    ($" Hello World! {System.Diagnostics.Process.GetCurrentProcess().ProcessName}" +
                    $" \n {configuration["MyMsg"]}");
                });
            });
 */