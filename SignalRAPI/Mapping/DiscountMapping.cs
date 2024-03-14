using AutoMapper;
using SignalR.DTOLayer.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Mapping
{
    public class DiscountMapping:Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount,CreateDiscountDto>().ReverseMap();
            CreateMap<Discount,UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount,ResultDiscountDto>().ReverseMap();
            CreateMap<Discount,GetByIdDiscountDto>().ReverseMap();
        }
    }
}
