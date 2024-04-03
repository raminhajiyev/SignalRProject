using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.DTOs.ContactDto
{
    public class UpdateContactDto
    {
        public int ContactId { get; set; }
        public string Location { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string FooterDescription { get; set; }
        public string OpeningHours { get; set; }
        public string OpeningDays { get; set; }
    }
}
