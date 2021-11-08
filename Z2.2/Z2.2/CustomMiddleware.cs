using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z2._2
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IFibonachi fib, FibonachiD f)
        {
            context.Response.ContentType = "text/html; charset=utf-8";

            for (int i = 0; i <= 10; i++)
            {
                fib.Fibo();
                await context.Response.WriteAsync($" {f.Value}");
            }
        }
    }
}
