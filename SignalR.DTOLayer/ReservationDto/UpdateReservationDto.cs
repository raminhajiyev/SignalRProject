using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DTOLayer.ReservationDto
{
    public class UpdateReservationDto
    {
        public int ReservationId { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}
