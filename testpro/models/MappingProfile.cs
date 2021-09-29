using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testpro.models;
using testpro.Repositories;
using AutoMapper;
using AutoMapper.Mappers;
namespace testpro.models
{
    public class MappingProfile : Profile
    {
        
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<UserViewModel, User>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();
            CreateMap<PostViewModel, Post>().ReverseMap();
            
           
        }
    }
}
