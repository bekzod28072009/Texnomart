using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Texnomart.Service.Dtos.ProductsDto;
using Texnomart.Service.Dtos.UsersDto;
using Texnomart.Service.IService.IProductsService;

namespace Texnomart.Controllers.ProductsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;
        public ProductController(IProductService service)
        {
            this.service = service;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(ProductDto dto)
           => Ok(await service.CreateAsync(dto));


        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
            => Ok(service.GetAll(p => p.Id != 0));


        [HttpPut("{id}")]
        public async ValueTask<IActionResult> UpdateAsync([FromRoute] int id, ProductDto dto)
            => Ok(service.Update(id, dto));


        [HttpGet("{id}")]
        public async ValueTask<IActionResult> GetAsync([FromRoute] int id)
            => Ok(await service.GetAsync(u => u.Id == id));


        [HttpDelete("{id}")]
        public async ValueTask<IActionResult> DeleteAsync([FromRoute] int id)
            => Ok(await service.DeleteAsync(p => p.Id == id));
    }
}
