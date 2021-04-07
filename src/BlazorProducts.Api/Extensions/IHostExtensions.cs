using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Microsoft.Extensions.Hosting
{
    public static class IHostExtensions
    {
        public static IHost MigrateDbContext<TContext>(this IHost host)
            where TContext : DbContext
        {
            return host.MigrateDbContext<TContext>((_, __) => { });
        }

        public static IHost MigrateDbContext<TContext>(this IHost host, Action<TContext, IServiceProvider> seeder)
            where TContext : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<TContext>();
                var environment = scope.ServiceProvider.GetService<IWebHostEnvironment>();

                try
                {
                    context.Database.Migrate();

                    if (environment.IsDevelopment())
                    {
                        seeder(context, scope.ServiceProvider);
                    }
                }
                catch (Exception ex)
                {
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<TContext>>();

                    logger.LogError(ex, $"An error occurred while migrating the database for context {nameof(TContext)}.");
                }
            }

            return host;
        }

        public static IHost Seeder<TContext>(
            this IHost webHost,
            Action<TContext, IServiceProvider> seeder) where TContext : DbContext
        {
            using (var scope = webHost.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<TContext>();
                seeder(context, scope.ServiceProvider);
            }

            return webHost;
        }
    }
}
