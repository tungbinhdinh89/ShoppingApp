using Microsoft.EntityFrameworkCore;
using ShoppingApp.API.Implementation;
using ShoppingApp.API.Services;
using ShoppingApp.Core.DB;

namespace ShoppingApp.API
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddScoped<IProductServices, ProductServices>();
        }

        public static IServiceCollection AddApplicationDb(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new Exception("Connection String not found");
            return services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));
        }
    }
}
