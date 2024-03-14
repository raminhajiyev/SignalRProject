using AutoMapper;
using SignalR.DTOLayer.CategoryDto;
using SignalR.DTOLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,GetByIdCategoryDto>().ReverseMap();
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
        }
    }
}
