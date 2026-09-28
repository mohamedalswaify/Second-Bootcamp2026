using Second_ASP_EF_MVC.Dtos.EmployeesDto;
using Second_ASP_EF_MVC.Models;

namespace Second_ASP_EF_MVC.Services.Base
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
