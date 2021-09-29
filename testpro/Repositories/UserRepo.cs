using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testpro.models;

namespace testpro.Repositories
{
    public class UserRepo : GenRepo<User>, IUserRepo
    {
        private readonly AppDbContext dbContext;
       public UserRepo(AppDbContext cont) : base(cont) {
            dbContext = cont;
        }
        public async Task<User> GetUserWithPosts(int id)
        {
            return dbContext.users.Include(x => x.posts).FirstOrDefault(p => p.Id == id);
        }
    }
   
}
