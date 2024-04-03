using AutoMapper;
using SignalR.DTOLayer.ContactDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
                CreateMap<Contact, CreateContactDto>().ReverseMap();
                CreateMap<Contact, ResultContactDto>().ReverseMap();
                CreateMap<Contact, UpdateContactDto>().ReverseMap();
                CreateMap<Contact, GetByIdContactDto>().ReverseMap();
        }
    }
}
