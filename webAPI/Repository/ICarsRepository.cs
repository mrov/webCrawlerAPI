using webAPI.Models;

namespace webAPI.Repository
{
    public interface ICarsRepository
    {
        Task<IEnumerable<Car>> GetAllCars();
    }
}
