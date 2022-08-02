using Microsoft.AspNetCore.Mvc;
using CarDealerships.BusinessLogic.Interfaces;
using CarDealerships.Common.Models;

namespace CarDealerships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalonsController : ControllerBase
    {
        private readonly ISalonService _salonService;

        public SalonsController(ISalonService salonService)
        {
            _salonService = salonService;
        }

        // GET: api/Salons
        [HttpGet]
        public ActionResult<IEnumerable<SalonModel>>Get()
        {
            return Ok(_salonService.Get());
        }

        // GET: api/Salons/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_salonService.Get(id));
        }

        // PUT: api/Salons/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, SalonModel salon)
        {
            _salonService.Update(id, salon);
            return Ok();
        }

        // POST: api/Salons
        [HttpPost]
        public ActionResult Post(SalonModel salon)
        {
            _salonService.Create(salon);
            return Ok();
        }

        // DELETE: api/Salons/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _salonService.Delete(id);
            return Ok();
        }

      
    }
}
