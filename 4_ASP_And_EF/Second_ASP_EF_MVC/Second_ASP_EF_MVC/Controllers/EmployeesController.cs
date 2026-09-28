using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Second_ASP_EF_MVC.Models;
using Second_ASP_EF_MVC.Services.Base;

namespace Second_ASP_EF_MVC.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _employeeService;


        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        public IActionResult Index()
        {
            var employees = _employeeService.GetAllEmployees();

            return View(employees);
        }


        public IActionResult Create()
        {
            var departments = _employeeService.GetAllDepartments();

            SelectList listItems =
                new SelectList(departments, "Id", "Name");

            ViewBag.DepartmentList = listItems;

            return View();
        }


        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.AddEmployee(employee);

                return RedirectToAction("Index");
            }

            return View(employee);
        }


        public IActionResult Edit(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

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
                _employeeService.UpdateEmployee(employee);

                return RedirectToAction("Index");
            }

            return View(employee);
        }


        public IActionResult Delete()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.DeleteEmployee(employee);

                return RedirectToAction("Index");
            }

            return View(employee);
        }
    }
}