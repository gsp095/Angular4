using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;
using Repository.Interface;

namespace Repository
{
    public class UserRepository : Repository<User>,IUserRepository
    {
        public UserRepository(AppDbContext _entities) : base(_entities)
        {
        }
    }
}
