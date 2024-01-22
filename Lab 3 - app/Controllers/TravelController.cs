using Microsoft.AspNetCore.Mvc;
using Lab_3___app.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Lab_3___app.Controllers
{
    //[Authorize]
    public class TravelController : Controller
    {
        private readonly ITravelService _travelService;

        public TravelController(ITravelService travelService)
        {
            _travelService = travelService;
        }

        public IActionResult Index()
        {
            return View(_travelService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            var list = _travelService.FindAllParticipants()
                .Select(e => new SelectListItem()
                {
                    Text = e.Name,
                    Value = e.Id.ToString(),
                }).ToList();

            return View(new Travel() { Organizations = list });
        }

        [HttpPost]
        public IActionResult Create(Travel model)
        {
            if (ModelState.IsValid)
            {
                _travelService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var travel = _travelService.FindById(id);
            travel.Organizations = _travelService.FindAllParticipants()
                .Select(e => new SelectListItem()
                {
                    Text = e.Name,
                    Value = e.Id.ToString(),
                }).ToList();

            return View(travel);
        }

        [HttpPost]
        public IActionResult Update(Travel model)
        {
            if (ModelState.IsValid)
            {
                _travelService.Update(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var travel = _travelService.FindById(id);
            if (travel != null)
            {
                return View(travel);
            }
            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _travelService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var travel = _travelService.FindById(id);
            if (travel != null)
            {
                return View(travel);
            }
            return NotFound();
        }

        public IActionResult CreateApi()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateApi(Travel c)
        {
            if (ModelState.IsValid)
            {
                _travelService.Add(c);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
