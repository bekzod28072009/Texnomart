using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texnomart.Service.Dtos.ProductsDto
{
    public class ProductDto
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string Country { get; set; }

        public string? Model { get; set; }

        public string? Size { get; set; }

        public string? Quality { get; set; }
    }
}
