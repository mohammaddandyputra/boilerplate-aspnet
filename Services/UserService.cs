using boilerplate_aspnet.Data.Context;
using boilerplate_aspnet.Models;
using boilerplate_aspnet.Common.Interface;
using boilerplate_aspnet.Common.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace boilerplate_aspnet.Services
{

    public class UserService : IGenericService<User, CreateUserDTO, UpdateUserDTO>
    {
        private ApplicationDbContext _db;
        public UserService(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        public async Task<IEnumerable<User>> getList()
        {
            return await _db.users.ToListAsync();
        }

        public async Task<User> get(Guid id)
        {
            return await _db.users.FirstOrDefaultAsync(e => e.id == id);
        }

        public async Task<User> create([FromBody] CreateUserDTO body)
        {
            return new User
            {
                name = "Elydha",
                email = "elydha@gmail.com",
                password = "123",
                roleId = new Guid("013a6a9f-a448-4fc1-bb4c-76671be69ad8")
            };
        }

        public async Task<User> update([FromBody] UpdateUserDTO body, Guid id)
        {
            return new User
            {
                name = "Elydha",
                email = "elydha@gmail.com",
                password = "123",
                roleId = new Guid("013a6a9f-a448-4fc1-bb4c-76671be69ad8")
            };
        }
    }
}