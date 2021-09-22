using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;
namespace testpro.Repositories
{
    public class PostRepo : GenRepo<Post>, IPostRepo
    {
        public PostRepo(AppDbContext cont) : base(cont) { }
    }
}
