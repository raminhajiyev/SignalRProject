using AutoMapper;
using SignalR.DTOLayer.ContactDto;

namespace SignalRAPI.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
                CreateMap<ContactMapping, CreateContactDto>().ReverseMap();
                CreateMap<ContactMapping, ResultContactDto>().ReverseMap();
                CreateMap<ContactMapping, UpdateContactDto>().ReverseMap();
                CreateMap<ContactMapping, GetByIdContactDto>().ReverseMap();
        }
    }
}
