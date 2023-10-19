using cardealers.Models;
using cardealers.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace cardealers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICarRepository _carRepository;
        public HomeController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IActionResult Index()
        {

            var cars = _carRepository.DownloadAllCars().OrderBy(s => s.Brand);

            var carsModel = new HomeVM()
            {
                Title = "View Cars",
                Cars = cars.ToList()

            };

            return View(carsModel);
        }
    }
}
