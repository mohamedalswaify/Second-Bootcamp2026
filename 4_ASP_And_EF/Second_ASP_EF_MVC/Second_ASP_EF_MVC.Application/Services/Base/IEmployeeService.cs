using Second_ASP_EF_MVC.Application.Dtos.EmployeesDto;
using Second_ASP_EF_MVC.Domain.Models;

namespace Second_ASP_EF_MVC.Application.Services.Base
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetAllEmployees();

        Employee GetEmployeeById(int id);

        void AddEmployee(Employee employee);

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        IEnumerable<Department> GetAllDepartments();

    }
}
