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

        public void AddCar(Car car)
        {
            _appDbContext.Cars.Add(car);
            _appDbContext.SaveChanges();
        }
        public void EditCar(Car car)
        {
            _appDbContext.Cars.Update(car);
            _appDbContext.SaveChanges();    
        }
        public void DeleteCar(Car car)
        {
            _appDbContext.Cars.Remove(car);
            _appDbContext.SaveChanges();    
        }
    }
}
