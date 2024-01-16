using Texnomart.Service.Dtos.ProductsDto;

namespace Texnomart.Service.Dtos.UsersDto
{
    public class UserDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Email { get; set; }

        public string PhoneNumber { get; set; }

        public string BankCard { get; set; }

        public ProductDto Product { get; set; }

        public int Payment { get; set; }
    }
}
