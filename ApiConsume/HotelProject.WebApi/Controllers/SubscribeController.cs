using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }
        [HttpGet]
        public IActionResult SubscribeList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddSubscribe(EntityLayer.Concrete.Subscribe p)
        {
            _subscribeService.TInsert(p);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe(int id)
        {
            var value = _subscribeService.TGetById(id);
            _subscribeService.TDelete(value);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSubscribe(EntityLayer.Concrete.Subscribe p)
        {
            _subscribeService.TUpdate(p);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var value = _subscribeService.TGetById(id);
            return Ok(value);
        }
    }
}
