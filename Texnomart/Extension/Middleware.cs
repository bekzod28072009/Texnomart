using Microsoft.EntityFrameworkCore;
using Texnomart.Data.AppDBContexts;
using Texnomart.Data.IRepository;
using Texnomart.Data.Repository;
using Texnomart.Domain.Entity.Products;
using Texnomart.Domain.Entity.Users;
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

        public static void AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
            services.AddTransient<IGenericRepository<Product>, GenericRepository<Product>>();
        }
    }
}
