using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.Configuration;
using AutoMapper;
using Joing.Api.Models;
using Joing.Core;
using Joing.DTO;
using Joing.Dto;

namespace Joing.Api.App_Start
{
    public class MappingProfile : Profile
    {
        public static void Configure() {
            Mapper.Initialize(
                cfg => {
                    cfg.CreateMap<RegisterBindingModel, ApplicationUser>()
                    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.FirstName));
                    cfg.AddProfile<DomainMapper>();
               }
            );  
            
        }
    }

    public class DomainMapper : Profile
    {
        public DomainMapper()
        {
            CreateMap<Condition, ConditionDto>();
            CreateMap<ConditionDto, Condition>();

            CreateMap<Location, LocationDto>();
            CreateMap<LocationDto, Location>();

            CreateMap<Event, EventDto>();
            CreateMap<EventDto, Event>();

        }

   
    }
}