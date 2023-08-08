using Dupus.Repository.Contracts.IRepositoryManagers;
using Dupus.Repository.EFCore.RepositoryContexts;
using Dupus.Repository.EFCore.RepositoryManagers;
using Dupus.Service.Contracts.IServiceManagers;
using Dupus.Service.ServiceManagers;
using Microsoft.EntityFrameworkCore;

namespace Dupus.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("Scienta"));
            });
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }
    }
}
