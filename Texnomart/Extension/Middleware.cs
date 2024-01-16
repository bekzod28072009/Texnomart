using Microsoft.EntityFrameworkCore;
using Texnomart.Data.AppDBContexts;

namespace Texnomart.Extension
{
    public static class Middleware
    {
        public static void AddDbConTextes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDBContext>(option =>
            option.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
