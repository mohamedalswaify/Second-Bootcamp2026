using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Second_ASP_EF_MVC.Data;
using Second_ASP_EF_MVC.Models;

namespace Second_ASP_EF_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        //Dependency Injection 

        private readonly AppDbContext _db;
        public EmployeeController(AppDbContext db)
        {
            _db = db;

        }


        public IActionResult Index()
        {
            //Entity Framework Approach           
            IEnumerable<Employee> employees = _db.Employees.ToList();
            return View(employees);
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
