using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web
{
    public static class AppCoreExtensions
    {
        public static IApplicationBuilder UseMainMiddleware(this IApplicationBuilder appBuilder)
        {
            return appBuilder.UseMiddleware<MainMiddleware>();
        }

        public static IApplicationBuilder UseSecondaryMiddleWare(this IApplicationBuilder appBuilder)
        {
            return appBuilder.UseMiddleware<SecondaryMiddleWare>();
        }
    }
}
