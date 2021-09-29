
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;
using testpro.Repositories;
using AutoMapper;
namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {


        private readonly IPostRepo postRepo;
        private readonly IMapper _mapper;
        public PostController(IPostRepo postRepo, Mapper mapper)
        {
            this.postRepo = postRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PostViewModel>> getall()
        {
            return _mapper.Map<List<Post>, List<PostViewModel>>(await postRepo.get());

        }
        [HttpGet("{id}")]
        public async Task<PostViewModel> Get(int id)
        {

            return _mapper.Map<PostViewModel>(await postRepo .get(id));
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