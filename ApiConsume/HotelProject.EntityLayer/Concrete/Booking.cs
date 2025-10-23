using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public string  AdultCount { get; set; } = string.Empty;
        public string  ChildCount { get; set; } = string.Empty;
        public string  RoomCount { get; set; } = string.Empty;
        public string SpecialRequest { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
