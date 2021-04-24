using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portal.Infrastructure.Persistence;
using Portal.Infrastructure.Persistence.EntityFramework;

namespace Portal.Application.System
{
    public static class ServiceCollectionExtensions
	{
        public static IServiceCollection InjectApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>),typeof(EfRepository<>));
            return services;
        }

        // veritabanı register ederken kullanılacak kısım
        // api startup içerisinden çağrılır.
        public static IServiceCollection AddCustomizedDataStore(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<PortalDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),b=> b.MigrationsAssembly("Portal.Infrastructure")));
            services.AddScoped<DbContext>(provider => provider.GetService<PortalDbContext>());
            return services;
        }
	}
}