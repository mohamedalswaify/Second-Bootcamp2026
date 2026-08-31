using Microsoft.AspNetCore.Mvc;

namespace Second_ASP_EF_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
