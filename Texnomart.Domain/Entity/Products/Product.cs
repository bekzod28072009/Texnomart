using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texnomart.Domain.Commons;

namespace Texnomart.Domain.Entity.Products
{
    public class Product : Auditable
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public string Country { get; set; }

        public string? Model { get; set; }

        public string? Size { get; set; }

        public string? Quality { get; set; }


    }
}
