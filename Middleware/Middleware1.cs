using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Middleware
{
    public class Middleware1
    {
        private readonly RequestDelegate _next;

        public Middleware1(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("Middleware 1 - BEFORE");

            // Call the next delegate/middleware in the pipeline
            await this._next(context);

            Console.WriteLine("Middleware 1 - AFTER");
        }
    }

    public static class Middleware1Extensions
    {
        public static IApplicationBuilder UseMiddleware1(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware1>();
        }
    }
}
