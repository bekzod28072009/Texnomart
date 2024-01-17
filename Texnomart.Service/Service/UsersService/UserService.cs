using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Texnomart.Data.IRepository;
using Texnomart.Domain.Entity.Users;
using Texnomart.Service.Dtos.UsersDto;
using Texnomart.Service.IService.IUsersService;

namespace Texnomart.Service.Service.UsersService
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> repository;
        private readonly IMapper mapper;
        public UserService(IGenericRepository<User> repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async ValueTask<UserDto> CreateAsync(UserDto entity)
        {
            var user = new User();
            if (entity is not null)
            {
                var newUser = mapper.Map<User>(entity);
                user = await repository.CreateAsync(newUser);
            }
            repository.SaveChangesAsync();
            return mapper.Map<UserDto>(user);
        }

        public async ValueTask<bool> DeleteAsync(Expression<Func<User, bool>> expression)
        {
            bool result = await repository.DeleteAsync(expression);
            await repository.SaveChangesAsync();
            return result;
        }

        public IQueryable<User> GetAll(Expression<Func<User, bool>> expression, string[] includes = null)
        => repository.GetAll(expression, includes);

        public async ValueTask<UserDto> GetAsync(Expression<Func<User, bool>> expression, string[] includes = null)
        {
            var user = await repository.GetAsync(expression, includes);
            return mapper.Map<UserDto>(user);
        }

        public UserDto Update(int id, UserDto entity)
        {
            var user = mapper.Map<User>(entity);
            user.Id = id;
            var newUser = repository.Update(user);
            return mapper.Map<UserDto>(newUser);
        }
    }
}
