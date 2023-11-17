using cardealers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing.Constraints;

namespace cardealers.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _env;

        
        public CarController(ICarRepository carRepository, Microsoft.AspNetCore.Hosting.IHostingEnvironment _env)
        {
            _carRepository = carRepository;
            _env = _env;
        }
        public IActionResult Index()
        {
            return View(_carRepository.DownloadAllCars());
        }

        public IActionResult Details(int id) 
        {
            var car = _carRepository.DownloadCarWithId(id);
            if (car == null)
                return NotFound();

            return View(car);
        }

        public IActionResult Create(string FileName)
        {
            if (!string.IsNullOrEmpty(FileName))
                ViewBag.ImgPath = "/Images/" + FileName;
            return View();  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car car) 
        {
            if (ModelState.IsValid) 
            {
                _carRepository.AddCar(car);
                return RedirectToAction("Index");
            }
            return View(car);
        }
        public IActionResult Edit(int Id, string FileName) 
        {
            var car = _carRepository.DownloadCarWithId(Id);
            if (car == null)
                return NotFound();

            if (!string.IsNullOrEmpty(FileName))
                ViewBag.ImgPath = "/Images/" + FileName;
            else
                ViewBag.ImgPath = car.PhotoUrl;

            return View(car);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                _carRepository.EditCar(car);
                return RedirectToAction("Index");
            }
            return View(car);
        }
        public IActionResult Delete(int Id)
        {
            var car = _carRepository.DownloadCarWithId(Id);
            if (car == null)
                return NotFound();  
            return View(car);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        
        public IActionResult DeleteConfirmed(int Id, string PhotoUrl)
        {
            var car = _carRepository.DownloadCarWithId(Id);
            _carRepository.DeleteCar(car);

            if (PhotoUrl != null)
            {
                var webRoot = _env.WebRootPath;
                var filePath = Path.Combine(webRoot.ToString() + PhotoUrl);
                System.IO.File.Delete(filePath);
            }


            return RedirectToAction("Index");
        }
        [HttpPost ("UploadFile")]
        
        public async Task<IActionResult> UploadFile(IFormCollection form)
        {
            var webRoot = _env.WebRootPath;
            var filePath = Path.Combine(webRoot.ToString() + "\\images\\" + form.Files[0].FileName);

            if (form.Files[0].FileName.Length > 0)
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await form.Files[0].CopyToAsync(stream);
                }
            }
            if (Convert.ToString(form["Id"]) == string.Empty || Convert.ToString(form["Id"]) == "0")
                return RedirectToAction(nameof(Create), new { FileName = Convert.ToString(form.Files[0].FileName) });

            return RedirectToAction(nameof(Edit), new { FileName = Convert.ToString(form.Files[0].FileName), id = Convert.ToString(form["Id"]) });
        }
    }
}
