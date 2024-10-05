using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RenameApp.Common;
using RenameApp.Dal;
using System;

namespace RenameApp.Dal
{
    public static class DalExtensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceProvider UseDatabaseEnsureCreated<TDbContext>(this IServiceProvider provider)
            where TDbContext : DbContext
        {
            using var serviceScope = provider.CreateScope();

            var serviceProvider = serviceScope.ServiceProvider;

            var context = serviceProvider.GetRequiredService<TDbContext>();

           // context.Database.EnsureCreated();

            return provider;
        }
    }
}
