using AutoMapper;
using SignalR.DTOLayer.HighlightDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Mapping
{
    public class HighlightMapping: Profile
    {
        public HighlightMapping()
        {
            CreateMap<Highlight, CreateHighlightDto>().ReverseMap();
            CreateMap<Highlight, UpdateHighlightDto>().ReverseMap();
            CreateMap<Highlight, ResultHighlightDto>().ReverseMap();
            CreateMap<Highlight, GetByIdHighlightDto>().ReverseMap();
        }
    }
}
