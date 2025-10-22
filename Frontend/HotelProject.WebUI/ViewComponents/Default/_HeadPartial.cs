using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default
{
    // _HeadPartial adında bir ViewComponent sınıfı tanımlanıyor
    // ViewComponent'ler genellikle reusable UI component'leri oluşturmak için kullanılır
    public class _HeadPartial : ViewComponent  // ViewComponent sınıfından türetiliyor
    {
        // ViewComponent'in ana metodudur - Invoke metodu otomatik olarak çağrılır
        public IViewComponentResult Invoke()
        {
            return View();  // ViewComponent'in varsayılan view'ını döndürür
        }
    }
}
