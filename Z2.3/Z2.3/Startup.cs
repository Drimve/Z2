using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Z2._3
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<Service>();
        }

        public void Configure(IApplicationBuilder app, Service S)
        {
            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/html; charset=utf-8";

                var path = context.Request.Path;
                string key = Convert.ToString(context.Request.Query["key"]);
                string value = Convert.ToString(context.Request.Query["value"]);
                if (path == "/add")
                {
                    S.Add(key, value);
                    await context.Response.WriteAsync($"<p>Новая запись добавлена:</p>" +
                            $"<p>Ключ: {key} Значение: {value}</p>");
                }
                else if (path == "/list")
                {
                    foreach (var a in S.Storage())
                    {
                        await context.Response.WriteAsync($"<p>Ключ: {a.Key}, значение: {a.Value}</p>");
                    }
                }

                else if (path == "/del")
                {
                    S.Del(key);
                    await context.Response.WriteAsync($"<p>Запись удалена:</p>" +
                       $"<p>Ключ: {key}</p>");
                }
            });
        }
    }
}
