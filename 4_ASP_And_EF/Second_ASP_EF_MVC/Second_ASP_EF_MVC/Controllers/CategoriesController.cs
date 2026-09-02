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


        public IActionResult Index()
        {
            //Entity Framework Approach           
            IEnumerable<Category> categories = _db.Categories.ToList();
            return View(categories);
        }


        public IActionResult Create()
        {
            return View();
        }






        }
}
