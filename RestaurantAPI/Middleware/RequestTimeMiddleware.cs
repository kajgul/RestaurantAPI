using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace RestaurantAPI.Middleware
{
    public class RequestTimeMiddleware : IMiddleware
    {
        private readonly ILogger<RequestTimeMiddleware> _logger;

        public RequestTimeMiddleware(ILogger<RequestTimeMiddleware> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            //Thread.Sleep(5000);
            await next.Invoke(context);
            stopwatch.Stop();
            var time = stopwatch.ElapsedMilliseconds;
            if (time > 4000)
            {
                var message = $"Request [{context.Request.Method}] at {context.Request.Path} took {time} ms";

                _logger.LogInformation(message);
            }
        }
    }
}