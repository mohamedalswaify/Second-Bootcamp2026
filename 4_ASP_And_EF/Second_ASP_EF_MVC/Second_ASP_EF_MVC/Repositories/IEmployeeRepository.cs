using Second_ASP_EF_MVC.Models;
using Second_ASP_EF_MVC.Repositories.Base;

namespace Second_ASP_EF_MVC.Repositories
{
    public interface IEmployeeRepository :IRepository<Employee>
    {


        IEnumerable<Employee> GetAllEmps();

    }
}
