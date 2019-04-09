using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web
{
    public class SecondaryMiddleWare
    {
        private RequestDelegate _next;

        public SecondaryMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("Hello Secondary MiddleWare!");
            await _next(context);
        }
    }
}
