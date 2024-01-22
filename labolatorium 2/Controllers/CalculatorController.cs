using labolatorium_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace labolatorium_2.Controllers
{
    public class CalculatorController : Controller
    {
        public enum Operators
        {
            add, sub, mul, div
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result([FromForm] Calculator model){
            if (!model.IsValid())
            {
                return View("error");
            }
        return View(model);
            
        }
    }
}
