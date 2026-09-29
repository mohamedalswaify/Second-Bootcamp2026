using Second_ASP_EF_MVC.Application.Dtos.EmployeesDto;
using Second_ASP_EF_MVC.Domain.Models;
using Second_ASP_EF_MVC.Infrastructure.Repositories.Base;
using Second_ASP_EF_MVC.Application.Services.Base;

namespace Second_ASP_EF_MVC.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            IEnumerable<Employee> employees =
                _unitOfWork.EmployeeRepo.GetAllEmps();

            IEnumerable<EmployeeDto> employeesDtos =
                employees.Select(e => new EmployeeDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description,
                    DepartmentName = e.Department.Name
                }).ToList();

            return employeesDtos;
        }


        public Employee GetEmployeeById(int id)
        {
            return _unitOfWork.EmployeeRepo.GetById(id);
        }


        public void AddEmployee(Employee employee)
        {
            _unitOfWork.EmployeeRepo.Add(employee);

            _unitOfWork.Save();
        }


        public void UpdateEmployee(Employee employee)
        {
            _unitOfWork.EmployeeRepo.Update(employee);
            _unitOfWork.Save();
        }


        public void DeleteEmployee(Employee employee)
        {
            _unitOfWork.EmployeeRepo.Delete(employee);
            _unitOfWork.Save();
        }


        public IEnumerable<Department> GetAllDepartments()
        {
            return _unitOfWork.DepartmentRepo.GetAll();
        }
    }
}