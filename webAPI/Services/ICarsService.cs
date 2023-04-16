using webAPI.Models;

namespace webAPI.Services
{
    public interface ICarsService
    {
        Task<IEnumerable<Car>> GetAllCars();
    }
}
