namespace cardealers.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Car> DownloadAllCars()
        {
            return _appDbContext.Cars;
        }

        public Car DownloadCarWithId(int carId)
        {
            var cars = _appDbContext.Cars.FirstOrDefault(s => s.Id == carId);
            return cars;
        }
    }
}
