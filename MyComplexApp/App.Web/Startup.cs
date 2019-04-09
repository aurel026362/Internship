using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Web.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //NEW CODE
            services.AddDbContext<MyAppContext>(options =>
            //options.UseSqlServer(@"Data Source=MDDSK40071\\TOMANDJERRY;Initial Catalog=test;Integrated Security=True"));
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            //@"Data Source=MDDSK40071\\TOMANDJERRY;Initial Catalog=test;Integrated Security=True"
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //---------MyCode
            //app.UseMiddleware<MainMiddleware>();
            //app.UseMiddleware<SecondaryMiddleWare>();
            //app.Run(async (context) =>
            //{
            //    var a = Configuration.GetConnectionString("DevConnection");
            //    await context.Response.WriteAsync("a=" + a);
            //});

            //app.UseMainMiddleware();
            //app.UseSecondaryMiddleWare();
            //---------------

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
