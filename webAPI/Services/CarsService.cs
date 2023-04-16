using webAPI.Models;
using webAPI.Repository;

namespace webAPI.Services
{
    public class CarsService : ICarsService
    {
        private readonly ICarsRepository _carRepository;

        public CarsService(ICarsRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<IEnumerable<Car>> GetAllCars()
        {
            return await _carRepository.GetAllCars();
        }
    }
}
