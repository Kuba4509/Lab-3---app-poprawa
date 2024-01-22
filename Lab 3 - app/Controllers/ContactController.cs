using Microsoft.AspNetCore.Mvc;
using Lab_3___app.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Lab_3___app.Controllers
{
    //[Authorize]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }


        [HttpGet]
        public IActionResult Create()
        {

            var list = _contactService.FindAllOrganizations()
                .Select(e => new SelectListItem()
                {
                    Text= e.Name,
                    Value = e.Id.ToString(),
                }).ToList();
            return View(new Contact() { Organizations = list});
        }

        [HttpPost]
        public IActionResult Create(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
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
            var contact = _contactService.FindById(id);
            contact.Organizations = _contactService.FindAllOrganizations()
            .Select(e => new SelectListItem()
            {
                Text = e.Name,
                Value = e.Id.ToString(),
            }).ToList();

            return View(contact);
        }
        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
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
            var contact = _contactService.FindById(id);
            if (contact != null)
            {
                return View(contact);
            }
            return NotFound();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _contactService.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var contact = _contactService.FindById(id);
            if (contact != null)
            {
                return View(contact);
            }
            return NotFound();
        }
        public IActionResult CreateApi()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateApi(Contact c)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(c);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
    }
}
