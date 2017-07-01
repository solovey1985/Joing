using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.Configuration;
using AutoMapper;
using Joing.Api.Models;

namespace Joing.Api.App_Start
{
    public class MappingProfile : Profile
    {
        public static void Configure() {
            Mapper.Initialize(cfg => cfg.CreateMap<RegisterBindingModel, ApplicationUser>()
            .ForMember(dest => dest.PhoneNumber , opt => opt.MapFrom(src => src.Phone))
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.FirstName)));  
            
        }
    }
}