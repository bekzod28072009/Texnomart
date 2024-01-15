using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texnomart.Domain.Commons;
using Texnomart.Domain.Entity.Products;

namespace Texnomart.Domain.Entity.Users
{
    public class User : Auditable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Email { get; set; }

        public string PhoneNumber { get; set; }

        public string BankCard { get; set; }

        public Product Product { get; set; }

        public int Payment { get; set; }
    }
}
