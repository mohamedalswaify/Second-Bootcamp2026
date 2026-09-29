using Second_ASP_EF_MVC.Infrastructure.Data;

namespace Second_ASP_EF_MVC.Infrastructure.Repositories.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;

        public UnitOfWork(AppDbContext db) 
        {
            _db = db;
            DepartmentRepo = new DepartmentRepository(db);
            EmployeeRepo = new EmployeeRepository(db);
            CategoryRepo = new CategoryRepository(db);


        }

        public IDepartmentRepository DepartmentRepo { get; }
        public IEmployeeRepository EmployeeRepo { get; }

        public ICategoryRepository CategoryRepo { get; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
