using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    // LoginController sınıfı, Controller sınıfından türetiliyor
    public class LoginController : Controller
    {
        // SignInManager dependency injection için readonly olarak tanımlanıyor
        private readonly SignInManager<AppUser> _signInManager;

        // Constructor - Dependency Injection ile SignInManager enjekte ediliyor
        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager; // Enjekte edilen SignInManager private field'a atanıyor
        }

        // HTTP GET isteği için Index action metodu
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Login view'ını döndürür
        }

        // HTTP POST isteği için Index action metodu (async)
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginUserDto)
        {
            if (ModelState.IsValid) //Modelstate dogruysa - Client-side validation başarılıysa
            {
                // Kullanıcı giriş işlemini gerçekleştir
                var result = await _signInManager.PasswordSignInAsync(loginUserDto.UserName, loginUserDto.Password, false, true);
                // Parametreler: username, password, isPersistent (remember me), lockoutOnFailure (başarısız girişte hesabı kilitle)

                if (result.Succeeded) // Giriş işlemi başarılıysa
                {
                    return RedirectToAction("Index", "Staff"); // Staff controller'ın Index action'ına yönlendir
                }
                else // Giriş işlemi başarısızsa
                {
                    return View(); // Aynı login view'ını tekrar göster
                }
            }
            return View(); // Model state geçerli değilse login view'ını tekrar göster
        }
    }
}
