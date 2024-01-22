using Laboratorium1._1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium1._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Calculator([FromQuery(Name ="op")]string op, double ?  a, double ? b)
            //dopisz sprawdzenie obecności operatora
        {
            if (op == null)
            {
                return View("error");
            }
            if (a == null || b == null)
            {
                return View("error");
            }
                //zbiór operatorów add, sub, mul, div
                //dokończ kalkulator
                if (op == "add")
            {
            ViewBag.Result = a+b;
            }
                if (op == "div")
            {
            ViewBag.Result = a / b;
            }
                if(op == "sub")
            {
            ViewBag.Result = a-b;
            }
                if(op == "mul")
            {
            ViewBag.Result = a * b;
            }
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}