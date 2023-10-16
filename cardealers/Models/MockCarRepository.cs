namespace cardealers.Models
{
    public class MockCarRepository : ICarRepository
    {
        private List<Car> cars;

        public MockCarRepository()
        {
            if (cars == null)
            {
                LoadCars();
            }
        }

        private void LoadCars()
        {
            cars = new List<Car>()
            {
                new Car { Id=1, Brand = "Ford", Model = "Mustang", ProductionYear = 2016, Mileage = "20 000 mi", Capacity =  "4 900 cm3", FuelType = "gas", Power = "421 KM", Description = "xxx", Price = 160000M , PhotoUrl = "/images/fordMustang.jpg", ThumbnailUrl = "/images/fordMustang.jpg", IsCarOfTheWeek = true },
                new Car { Id=2, Brand = "Audi", Model = "S5", ProductionYear = 2013, Mileage = "66 000 mi", Capacity =  "3 000 cm3", FuelType = "gas", Power = "280 KM", Description = "xxx", Price = 115000M , PhotoUrl = "/images/audiS5.jpg", ThumbnailUrl = "/images/audiS5.jpg", IsCarOfTheWeek = true },
                new Car { Id=3, Brand = "BMW", Model = "X4", ProductionYear = 2017, Mileage = "2 500 mi", Capacity =  "1 995 cm3", FuelType = "gas", Power = "190 KM", Description = "xxx", Price = 194000M , PhotoUrl = "/images/bmvx4.jpg", ThumbnailUrl = "/images/bmvx4.jpg", IsCarOfTheWeek = true },
            };
        }

        public Car DownloadCarWithId(int carId)
        {
            return cars.FirstOrDefault(s => s.Id == carId);
        }

    public IEnumerable<Car> DownloadAllCars()
      {
            return cars;
       }
    }
}
