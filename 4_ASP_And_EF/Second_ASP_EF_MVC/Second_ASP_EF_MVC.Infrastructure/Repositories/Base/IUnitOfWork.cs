namespace Second_ASP_EF_MVC.Infrastructure.Repositories.Base
{
    public interface IUnitOfWork
    {
        IDepartmentRepository DepartmentRepo { get; }

        IEmployeeRepository EmployeeRepo { get; }

        ICategoryRepository CategoryRepo { get; }

        void Save();
    }
}
