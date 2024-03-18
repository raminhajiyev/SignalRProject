using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DTOLayer.ReservationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet]
        public IActionResult GetListReservation()
        {
            var values= _reservationService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateReservation(CreateReservationDto createReservationDto)
        {
            Reservation reservation = new Reservation()
            {
                Date = createReservationDto.Date,
                Fullname = createReservationDto.Fullname,
                Mail = createReservationDto.Mail,
                PersonCount = createReservationDto.PersonCount,
                Phone = createReservationDto.Phone,

            };
            _reservationService.TAdd(reservation);
            return Ok("Data has been added successfully");
        }
        [HttpPut]
        public IActionResult UpdateReservation(UpdateReservationDto updateReservationDto)
        {
            Reservation reservation = new Reservation()
            {
                ReservationId=updateReservationDto.ReservationId,
                Date = updateReservationDto.Date,
                Fullname = updateReservationDto.Fullname,
                Mail = updateReservationDto.Mail,
                PersonCount = updateReservationDto.PersonCount,
                Phone = updateReservationDto.Phone
            };
            _reservationService.TUpdate(reservation);
            return Ok("Data has been updated successfully");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteReservation(int id)
        {
            var value=_reservationService.TGetByID(id);
            _reservationService.TDelete(value);
            return Ok("Data has been deleted successfully");
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdReservation(int id)
        {
            var value = _reservationService.TGetByID(id);
            
            return Ok(value);
        }

    }
}
