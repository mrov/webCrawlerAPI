using Microsoft.AspNetCore.Mvc;
using webAPI.Models;
using webAPI.Services;

namespace webAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {

        private readonly ILogger<CarsController> _logger;
        private readonly ICarsService _carsService;

        public CarsController(ILogger<CarsController> logger, ICarsService carsService)
        {
            _logger = logger;
            _carsService = carsService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCars()
        {
            var results = await _carsService.GetAllCars();
            return Ok(results);
        }
    }
}