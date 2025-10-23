using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 📦 Bu sınıf HotelProject projesinin DataAccessLayer katmanında yer alıyor.
namespace HotelProject.DataAccessLayer.EntityFramework
{
    // 🏗️ EfBookingDal sınıfı:
    // - GenericRepository<Booking> sınıfından miras alıyor (CRUD işlemlerini kullanmak için)
    // - IBookingDal arayüzünü (interface) uyguluyor (bağımlılığı azaltmak için)
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        // ⚙️ Constructor (yapıcı metot):
        // Context (DbContext) nesnesini parametre olarak alır ve base class'a (GenericRepository) iletir.
        public EfBookingDal(Context context) : base(context)
        {
            // 🧠 Şu anda ekstra bir işlem yapılmıyor,
            // ancak istenirse burada Booking tablosuna özel sorgular eklenebilir.
        }
    }
}
