namespace SignalR.EntityLayer.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}
