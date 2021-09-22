
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;
using testpro.Repositories;
namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {


        private readonly IPostRepo postRepo;
        public PostController(IPostRepo postRepo)
        {
            this.postRepo = postRepo;
        }

        [HttpGet]
        public IEnumerable<Post> getall()
        {
            return postRepo.get();

        }
        [HttpGet("{id}")]
        public Post Get(int id)
        {

            return postRepo.get(id);
        }
        [HttpPost]
        public void addPost([FromBody] Post p)
        {
            postRepo.add(p);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            postRepo.delete(id);
        }

    }

}