using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad alani Geçilemez!")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Soyad alani Geçilemez!")]
        public string Surname { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Mail alani Geçilemez!")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir mail adresi giriniz!")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Şifre alani bos Geçilemez!")]
        public string Password { get; set; } = string.Empty;
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor!")]
        public string ConfirmPassword { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
