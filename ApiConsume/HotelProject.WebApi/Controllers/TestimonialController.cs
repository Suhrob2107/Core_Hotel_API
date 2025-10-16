using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            this.testimonialService = testimonialService;
        }
        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = testimonialService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonial(EntityLayer.Concrete.Testimonial p)
        {
            testimonialService.TInsert(p);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = testimonialService.TGetById(id);
            testimonialService.TDelete(value);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(EntityLayer.Concrete.Testimonial p)
        {
            testimonialService.TUpdate(p);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = testimonialService.TGetById(id);
            return Ok(value);
        }
    }
}
