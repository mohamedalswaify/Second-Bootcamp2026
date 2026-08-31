using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Second_ASP_EF_MVC.Models;

namespace Second_ASP_EF_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //public IActionResult Mohamed()
        //{
        //    //Array data
        //    IList<string> list = new List<string>();
        //    list.Add("Mohamed");
        //    return StatusCode(304,list);
        //}

        public IActionResult Test()
        {
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id=1,Name="Mohamed",Description="Test"});
            employees.Add(new Employee { Id=2,Name="Ali",Description="Test"});
            employees.Add(new Employee { Id=3,Name="Ahmed",Description="Test"});
            employees.Add(new Employee { Id=4,Name="Sara",Description="Test"});

            return View(employees);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
