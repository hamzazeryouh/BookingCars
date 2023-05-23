using Domain.Entites;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookingCars.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        ICarRepository _carRepository;
        public CarController (ICarRepository carRepository) { 
        _carRepository= carRepository;
        }
        // GET: api/<CarController>
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            return _carRepository.GetAllCars();
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public Car Get(int id)
        {
           return _carRepository.GetCarById(id);
        }

        // POST api/<CarController>
        [HttpPost]
        public async void Post([FromBody] Car model)
        {
             _carRepository.AddCar(model);
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Car model)
        {
            _carRepository.UpdateCar(model);
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var car = _carRepository.GetCarById(id);
            if (car != null)
            {
                _carRepository.DeleteCar(car);
            }
            return NotFound("this Car not Existe");
        }
    }
}
