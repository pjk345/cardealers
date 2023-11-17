namespace cardealers.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> DownloadAllCars();
        Car DownloadCarWithId(int carId);

        void AddCar(Car car);
        void EditCar(Car car);
        void DeleteCar(Car car);
    }
}
