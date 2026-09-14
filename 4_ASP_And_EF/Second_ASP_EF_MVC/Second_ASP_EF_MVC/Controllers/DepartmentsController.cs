using Microsoft.AspNetCore.Mvc;
using Second_ASP_EF_MVC.Data;
using Second_ASP_EF_MVC.Dtos.DepartmentsDtos;
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

            var departments = _db.Departments.Select(d => new DepartmentDto
            {
                Id = d.Id,
                Name = d.Name,

            });

            return View(departments);
        }

        // =========================
        // Create
        // =========================



        [HttpPost]
        public IActionResult Create(CreateDepartmentDto department)
        {
        

            if (ModelState.IsValid)
            {
                //Mapping
                var dept = new Department
                {
                    Name = department.Name,
                };

                _db.Departments.Add(dept);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        // =========================
        // Edit
        // =========================
        [HttpPost]
        public IActionResult Edit(UpdateDepartmentDto department)
        {
            if (ModelState.IsValid)
            {
                var dept = new  Department 
                    { 
                    Name = department.Name,
                    Id=department.Id
                };
                _db.Departments.Update(dept);
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
