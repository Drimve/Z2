using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z2
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IFibonachiN a)
        {
            context.Response.ContentType = "text/html; charset=utf-8";

            for (int i = 0; i < 10; i++)
            {
                a.Fib();
                await context.Response.WriteAsync($"<p>{a.Value.ToString()}</p>");
            }
        }
    }
}
