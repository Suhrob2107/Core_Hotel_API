using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage ="Lutfen oda numarasini giriniz")]
        public string RoomNumber { get; set; } = string.Empty;
        public string RoomCoverImage { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lutfen fiyat bilgisini giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lutfen baslik bilgisini giriniz")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lutfen yatak sayisini giriniz")]
        public string BedCount { get; set; } = string.Empty;
        [Required(ErrorMessage = "Lutfen banyo sayisini giriniz")]
        public string BathCount { get; set; } = string.Empty;
        public string Wifi { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
