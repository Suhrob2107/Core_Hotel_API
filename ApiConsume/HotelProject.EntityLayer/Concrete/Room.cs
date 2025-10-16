using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public string RoomCoverImage { get; set; } = string.Empty;
        public int Price { get; set; }
        public string Title { get; set; } = string.Empty;
        public string BedCount { get; set; } = string.Empty;
        public string BathCount { get; set; } = string.Empty;
        public string Wifi { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
