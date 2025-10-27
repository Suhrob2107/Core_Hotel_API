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

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new Context();
            var values = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved2(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }
    }
}
