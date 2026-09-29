using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Second_ASP_EF_MVC.Application.Dtos.EmployeesDto;
using Second_ASP_EF_MVC.Application.Services.Base;
using Second_ASP_EF_MVC.Domain.Models;

namespace Second_ASP_EF.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;


        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetEmployee()
        {
            var employees = _employeeService.GetAllEmployees();

            return Ok(employees);
        }

        //Creat Employee
        [HttpPost]
        public IActionResult CreateEmployee(CreateEmployee employeeDto )
        {

            try
            {
                var emp = new Employee
                {
                    Name = employeeDto.Name,
                    DepartmentId = employeeDto.DepartmentId,
                    Description = employeeDto.Description,
                };
                _employeeService.AddEmployee(emp);


                return Ok(emp);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }






    }
}
