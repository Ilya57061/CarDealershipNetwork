using Microsoft.AspNetCore.Mvc;
using CarDealerships.BusinessLogic.Interfaces;
using CarDealerships.Common.Models;

namespace CarDealerships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        // GET: api/Salons
        [HttpGet]
        public ActionResult<IEnumerable<CarModel>> Get()
        {
            return Ok(_carService.Get());
        }

        // GET: api/Salons/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_carService.Get(id));
        }

        // PUT: api/Salons/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, CarModel car)
        {
            _carService.Update(id, car);
            return Ok();
        }

        // POST: api/Salons
        [HttpPost]
        public ActionResult Post(CarModel car)
        {
            _carService.Create(car);
            return Ok();
        }

        // DELETE: api/Salons/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _carService.Delete(id);
            return Ok();
        }
    }
}
