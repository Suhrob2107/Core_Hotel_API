using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public string ServiceId { get; set; } = string.Empty;
        [Required(ErrorMessage = "Boş geçilemez!")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Boş geçilemez!")]
        public string Icon { get; set; } = string.Empty;
        [Required(ErrorMessage = "Boş geçilemez!")]
        public string Description { get; set; } = string.Empty;
    }
}
