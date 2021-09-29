using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http;

namespace testpro.models
{
    public class UseEXMiddleware
    {
        private readonly RequestDelegate _next;
        public UseEXMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            
            await _next(context);
        }
        
    }
}
