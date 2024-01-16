using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Texnomart.Domain.Entity.Users;
using Texnomart.Service.Dtos.UsersDto;

namespace Texnomart.Service.IService.IUsersService
{
    public interface IUserService
    {
        IQueryable<User> GetAll(Expression<Func<User, bool>> expression, string[] includes = null);
        ValueTask<UserDto> GetAsync(Expression<Func<User, bool>> expression, string[] includes = null);
        ValueTask<UserDto> CreateAsync(UserDto entity);
        ValueTask<bool> DeleteAsync(Expression<Func<User, bool>> expression);
        UserDto Update(int id, UserDto entity);
    }
}
