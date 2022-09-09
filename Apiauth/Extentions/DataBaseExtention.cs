using Apiauth.Data;
using Microsoft.EntityFrameworkCore;



namespace Apiauth.Extentions
{
    public static class DatabaseExtensions
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();

            var configuration = serviceProvider.GetRequiredService<IConfiguration>();

            services.AddDbContext<AppDataContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
} 