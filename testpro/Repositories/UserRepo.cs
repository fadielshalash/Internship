using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;

namespace testpro.Repositories
{
    public class UserRepo : GenRepo<User>, IUserRepo
    {
       public UserRepo(AppDbContext cont) : base(cont) { }
    }
}
