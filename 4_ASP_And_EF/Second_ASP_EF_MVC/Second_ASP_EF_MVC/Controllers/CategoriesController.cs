using Microsoft.AspNetCore.Mvc;
using Second_ASP_EF_MVC.Data;
using Second_ASP_EF_MVC.Models;

namespace Second_ASP_EF_MVC.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly AppDbContext _db;
        public CategoriesController(AppDbContext db)
        {
            _db = db;

        }


        [HttpGet]
        public IActionResult Index()
        {
            //Entity Framework Approach           
            IEnumerable<Category> categories = _db.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }   
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(string uid)
        {
            var category = _db.Categories.FirstOrDefault(e=>e.UID == uid);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                if(category.UID ==null)
                    category.UID = Guid.NewGuid().ToString();

                _db.Categories.Update(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Delete(string uid)
        {
            var category = _db.Categories.FirstOrDefault(e => e.UID == uid);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


        [HttpPost]
        public IActionResult Delete(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }



    }
}
