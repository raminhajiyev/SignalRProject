using AutoMapper;
using SignalR.DTOLayer.ReservationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Mapping
{
    public class ReservationMapping: Profile
    {
        public ReservationMapping()
        {
            CreateMap<Reservation,CreateReservationDto>().ReverseMap();
            CreateMap<Reservation,ResultReservationDto>().ReverseMap();
            CreateMap<Reservation,GetByIdReservationDto>().ReverseMap();
            CreateMap<Reservation,UpdateReservationDto>().ReverseMap();
        }
    }
}
