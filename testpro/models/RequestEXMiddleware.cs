using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testpro.models
{
    public static class RequestEXMiddleware
    {
        public static IApplicationBuilder UseRequestEX(
           this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UseEXMiddleware>();
        }
    }
}
