using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.Repositories;
namespace testpro.models
{
    public static class Service
    {
        public static void Addservices(this IServiceCollection service)
        {
            service.AddControllers();
            service.AddSwaggerGen();
            //Singleton uses a single object for all requests so all changes are viewable
            service.AddSingleton<IUser, UserService>();
            //Scoped uses a single scope object for each request, so changes are not seen between requests
            service.AddScoped<IUser, UserService>();
            service.AddTransient<IUser, UserService>();
            service.AddScoped<IUserRepo, UserRepo>();
            service.AddScoped<IPostRepo, PostRepo>();
        }
        public static void AddDbContext(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(optionsAction: options => options.UseSqlServer(configuration.GetConnectionString(name: "DefaultConnection")));
        }
    }
}
