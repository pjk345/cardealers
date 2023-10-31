using cardealers.Models;
using Microsoft.AspNetCore.Mvc;

namespace cardealers.Controllers
{
    public class OpinionController : Controller
    {
        private readonly IOpinionRepository _opinionRepository;

        public OpinionController(IOpinionRepository opinionRepository)
        {
            _opinionRepository = opinionRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinion opinion)
        {
            if(ModelState.IsValid) 
            {
                _opinionRepository.AddOpiniion(opinion);
                return RedirectToAction("OpinionSent");
            }
            
            return View(opinion);
            
        }

        public IActionResult OpinionSent()
        {
            return View();
        }
    }
}
