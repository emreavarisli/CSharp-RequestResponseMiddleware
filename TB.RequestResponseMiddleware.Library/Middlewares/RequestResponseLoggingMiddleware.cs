using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB.RequestResponseMiddleware.Library.Middlewares
{
    internal class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate next;

        public async Task Invoke(HttpContext context)
        {
            await next(context);
        }
    }
}
