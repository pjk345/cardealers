namespace cardealers.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> DownloadAllCars();
        Car DownloadCarWithId(int carId);
    }
}
