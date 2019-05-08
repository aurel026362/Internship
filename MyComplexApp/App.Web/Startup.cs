using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Context;
using App.Data.Domain.DomainModels.Concrete;
using App.Data.Domain.DomainModels.Identity;
using App.Data.Interfaces.RepositoryInterfaces;
using App.Data.Interfaces.RepositoryInterfaces.IComplexRepository;
using App.Data.Repository;
using App.Data.Repository.ComplexRepository;
using App.Services;
using App.Services.Interfaces;
using App.Services.Interfaces.IServices;
using App.Services.Services;
using App.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
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
            //services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<DbContext, MyAppContext>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IRepository<App.Data.Domain.DomainModels.Concrete.Module>, 
              //  GenericRepository<App.Data.Domain.DomainModels.Concrete.Module>>();
            //services.AddScoped<IRepository<Group>, GenericRepository<Group>>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IExamMarkRepository, ExamMarkRepository>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IThemeRepository, ThemeRepository>();
            services.AddScoped<IThemeMarkRepository, ThemeMarkRepository>();
            services.AddScoped<IGenericRepository<Group>, GenericRepository<Group>>();
            services.AddScoped<IGenericRepository<Module>, GenericRepository<Module>>();

            //add service dependence
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IEMarkService, ExamMarkService>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IModuleService, ModuleService>();
            services.AddScoped<IThemeService, ThemeService>();
            services.AddScoped<ITMarkService, ThemeMarkService>();
            services.AddScoped<IUserService, UserService>();


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddIdentity<User, Role>(opt =>
            {
                opt.Password.RequiredLength = 6;
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;

            }).AddEntityFrameworkStores<MyAppContext>().AddDefaultTokenProviders();
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IEmailSender, EmailSender>();
            //NEW CODE
            services.AddDbContext<MyAppContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
        .AddRazorPagesOptions(options =>
        {
            options.AllowAreas = true;
            options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
            options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");
        });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });

            //------
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultChallengeScheme = FacebookDefaults.AuthenticationScheme;
            //    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            //}).AddFacebook(options =>
            //{
            //    options.AppId = "806605686400556";
            //    options.AppSecret = "72dc791ece58b9bb0a6543d43a7af3c4";
            //});

            //services.AddAuthentication().AddGoogle(options =>
            //{
            //    options.ClientId = Configuration["GoogleId"];
            //    options.ClientSecret = Configuration["GoogleSecret"];
            //});

            // using Microsoft.AspNetCore.Identity.UI.Services;
            //services.AddSingleton<IEmailSender, EmailSender>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAutoMapper();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseMiddleware<CustomMiddleware>();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();
            

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
