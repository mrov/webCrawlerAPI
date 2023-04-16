using MongoDB.Driver;
using webAPI.Models;

namespace webAPI.Repository
{
    public class CarsRepository : ICarsRepository
    {
        private readonly IMongoCollection<Car> _cars;

        public CarsRepository(MongoClient client, IConfiguration config)
        {
            var databaseName = config.GetValue<string>("MongoDb:DatabaseName");
            var collectionName = config.GetValue<string>("MongoDb:CollectionName");
            var database = client.GetDatabase(databaseName);
            _cars = database.GetCollection<Car>(collectionName);
        }

        public async Task<IEnumerable<Car>> GetAllCars()
        {
            return await _cars.Find(car => true).ToListAsync();
        }
    }
}
