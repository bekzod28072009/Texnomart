using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texnomart.Domain.Entity.Products;
using Texnomart.Domain.Entity.Users;

namespace Texnomart.Data.AppDBContexts
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base (options) 
        { }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
