using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;
namespace testpro.Repositories
{
    public interface IUserRepo : IGenRepo<User> 
    {
        public Task<User> GetUserWithPosts(int id);
    }
}
