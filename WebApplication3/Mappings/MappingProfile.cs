using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApplication3.Models;
using WebApplication3.Models.DTO;

namespace WebApplication3.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>()
           .ForMember(dest => dest.FollowMe, act => act.MapFrom(src => src.FollowerFollowerAferNavigations));
        }
    }
}
