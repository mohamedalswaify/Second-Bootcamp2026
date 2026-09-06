using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Second_ASP_EF_MVC.Data;
using Second_ASP_EF_MVC.Models;

namespace Second_ASP_EF_MVC.Controllers
{
    public class EmployeesController : Controller
    {
        //Dependency Injection 

        private readonly AppDbContext _db;
        public EmployeesController(AppDbContext db)
        {
            _db = db;

        }


        public IActionResult Index()
        {
            //Entity Framework Approach           
            IEnumerable<Employee> employees = _db.Employees.Include(e=>e.Department).ToList();
            return View(employees);
        }


        public IActionResult Create()
        {
            IEnumerable<Department> departmentList = _db.Departments.ToList();

            SelectList listItems = new SelectList(departmentList, "Id", "Name");
            ViewBag.DepartmentList = listItems;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Edit(int id)
        {

            
          

           var employee = _db.Employees.Include(e => e.Department).FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Update(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Delete()
        {
            //ViewBag.Departments = _db.Departments.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Remove(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Details(int id)
        {
            //ViewBag.Departments = _db.Departments.ToList();
            var employee = _db.Employees.Include(e => e.Department).FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }



        //public IActionResult Index()
        //{
        //    //Ado.Net Approach
        //    var sql = "SELECT * FROM Employees";
        //    var employees = _db.Employees
        //                       .FromSqlRaw(sql)
        //                       .ToList();
        //    return View(employees);
        //}


    }
}
