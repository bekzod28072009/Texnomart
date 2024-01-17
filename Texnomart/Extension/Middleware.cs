using Microsoft.EntityFrameworkCore;
using Texnomart.Data.AppDBContexts;
using Texnomart.Service.IService.IProductsService;
using Texnomart.Service.IService.IUsersService;
using Texnomart.Service.Service.ProductsService;
using Texnomart.Service.Service.UsersService;

namespace Texnomart.Extension
{
    public static class Middleware
    {
        public static void AddDbConTextes(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDBContext>(option =>
            option.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }

        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
