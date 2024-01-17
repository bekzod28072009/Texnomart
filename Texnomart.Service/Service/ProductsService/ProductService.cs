using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Texnomart.Data.IRepository;
using Texnomart.Domain.Entity.Products;
using Texnomart.Domain.Entity.Users;
using Texnomart.Service.Dtos.ProductsDto;
using Texnomart.Service.Dtos.UsersDto;
using Texnomart.Service.IService.IProductsService;

namespace Texnomart.Service.Service.ProductsService
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> repository;
        private readonly IMapper mapper;
        public ProductService(IGenericRepository<Product> repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async ValueTask<ProductDto> CreateAsync(ProductDto entity)
        {
            var product = new Product();
            if (entity is not null)
            {
                var newProduct = mapper.Map<Product>(entity);
                product = await repository.CreateAsync(newProduct);
            }
            repository.SaveChangesAsync();
            return mapper.Map<ProductDto>(product);
        }

        public async ValueTask<bool> DeleteAsync(Expression<Func<Product, bool>> expression)
        {
            bool result = await repository.DeleteAsync(expression);
            await repository.SaveChangesAsync();
            return result;
        }

        public IQueryable<Product> GetAll(Expression<Func<Product, bool>> expression, string[] includes = null)
        => repository.GetAll(expression, includes);

        public async ValueTask<ProductDto> GetAsync(Expression<Func<Product, bool>> expression, string[] includes = null)
        {
            var product = await repository.GetAsync(expression, includes);
            return mapper.Map<ProductDto>(product);
        }

        public ProductDto Update(int id, ProductDto entity)
        {
            var product = mapper.Map<Product>(entity);
            product.Id = id;
            var newProduct = repository.Update(product);
            return mapper.Map<ProductDto>(newProduct);
        }
    }
}
