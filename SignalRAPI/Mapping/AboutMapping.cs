using AutoMapper;
using SignalR.DTOLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
                CreateMap<About,CreateAboutDto>().ReverseMap();
                CreateMap<About,UpdateAboutDto>().ReverseMap();
                CreateMap<About,ResultAboutDto>().ReverseMap();
                CreateMap<About,GetByIdAboutDto>().ReverseMap();
        }
    }
}
