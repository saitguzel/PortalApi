using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portal.Infrastructure.Persistence;
using Portal.Infrastructure.Persistence.EntityFramework;
using Microsoft.OpenApi.Models;
using AutoMapper;
using System.Reflection;

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

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly()); // aynı dll de olanları regisiter eder
            return services;
        }

        public static IServiceCollection IntegrateSwagger(this IServiceCollection services, IConfiguration configuration)
        {   
            services.AddSwaggerGen(options =>{
                options.SwaggerDoc("v1", new OpenApiInfo{
                    Title=configuration["Swagger:Title"],
                    Version = configuration["Swagger:Version"],
                    Description = configuration["Swagger:Description"]
                });
                options.CustomOperationIds(x =>x.GroupName);
            }) ;
            return services;   
        }

	}
}