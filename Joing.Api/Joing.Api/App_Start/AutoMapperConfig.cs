using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper.Configuration;
using AutoMapper;
using Joing.Api.Models;
using Joing.Core;
using Joing.DTO;

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
            CreateMap<Event, EventDto>()
                .ForMember(dest=>dest.Address, opt=>opt.MapFrom(src=>src.Place.Address))
                .ForMember(dest=>dest.MapUrl, opt=>opt.MapFrom(src=>src.Place.MapUrl))
                .ForMember(dest=>dest.Latitude, opt=>opt.MapFrom(src=>src.Place.Latitude))
                .ForMember(dest=>dest.Longitude, opt=>opt.MapFrom(src=>src.Place.Longitude))
                ;
            CreateMap<EventDto, Event>()
               .ForMember(dest => dest.Place, opt => opt.ResolveUsing<LocationResolver>())
                ;

        }

        public class LocationResolver : IValueResolver<EventDto, Event, Location>
        {
            public Location Resolve(EventDto source, Event destination, Location destMember, ResolutionContext context)
            {
                return Location.Create(source.Address);
            }

           
        }
    }
}