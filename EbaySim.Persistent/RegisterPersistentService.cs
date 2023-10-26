using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EbaySim.Persistent
{
    public static class RegisterPersistentService
    {
        public static IServiceCollection AddPersistentServices(
           this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EbaySimContext>(options => {
                options.UseSqlServer(
                configuration.GetConnectionString(
                        "DatabaseConnectionString"));
            });
            //services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
