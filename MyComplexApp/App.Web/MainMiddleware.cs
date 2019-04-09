using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web
{
    public class MainMiddleware
    {
        private RequestDelegate _next;

        public MainMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.Response.WriteAsync("Hello Main MiddleWare!");
            return _next(context);
        }
    }
}
