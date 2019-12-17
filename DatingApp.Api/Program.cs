using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DatingApp.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hostBuilder = CreateHostBuilder(args).Build();
            using (var scope = hostBuilder.Services.CreateScope())
            {
             var services = scope.ServiceProvider;
             try
             {
                 var context = services.GetRequiredService<DataContext>();
                 context.Database.Migrate();
                 Seed.SeedUsers(context);
             }
             catch (System.Exception ex)
             {
                 var logger = services.GetRequiredService<ILogger<Program>>();
                 logger.LogError(ex, "An error occured during migration");
             }   
            }

            hostBuilder.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
