using labolatorium_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace labolatorium_2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Birth()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(Birth model)
        {
            if (model.IsValid())
            {
                int wiek = model.howold();
                return View("Result", model);
            }
            else
            {
                return View("Error");
            }
        }
    }
}
