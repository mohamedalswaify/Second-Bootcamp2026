using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Second_ASP_EF_MVC.Data;
using Second_ASP_EF_MVC.Models;

namespace Second_ASP_EF_MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _db;
        public ProductsController(AppDbContext db) 
        { 
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> products = _db.Products.Include(e => e.Category).ToList();
            return View(products);
            
        }

        private void GetCategories()
        {
            IEnumerable<Category> categories = _db.Categories.ToList();
            SelectList categorySelectList = new SelectList(categories, "Id", "Name");
            ViewBag.CategorySelectList = categorySelectList;

        }

        public IActionResult Create()
        {
            GetCategories();

            return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            GetCategories();
            return View(product);
        }

        public IActionResult Edit(int Id)
        {
            GetCategories();

            Product product = _db.Products.Find(Id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }


        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Update(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            GetCategories();
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            if (ModelState.IsValid)
            {
                Product product = _db.Products.Find(Id);
                if (product == null)
                {
                    return NotFound();
                }
                _db.Products.Remove(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            GetCategories();
            return View();
        }

    }
}
