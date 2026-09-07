using Microsoft.AspNetCore.Mvc;
using Second_ASP_EF_MVC.Data;
using Second_ASP_EF_MVC.Models;

namespace Second_ASP_EF_MVC.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _db;

        public DepartmentsController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            var departments = _db.Departments.ToList();

            return View(departments);
        }

        // =========================
        // Create
        // =========================
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _db.Departments.Add(department);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        // =========================
        // Edit
        // =========================
        [HttpPost]
        public IActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                _db.Departments.Update(department);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        // =========================
        // Delete
        // =========================
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var department = _db.Departments.Find(id);

            if (department != null)
            {
                _db.Departments.Remove(department);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
