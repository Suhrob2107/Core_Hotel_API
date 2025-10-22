using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanici adini giriniz")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Sifreyi giriniz")]
        public string Password { get; set; } = string.Empty;
    }
}
