using Microsoft.EntityFrameworkCore;
using Second_ASP_EF_MVC.Infrastructure.Data;
using Second_ASP_EF_MVC.Domain.Models;
using Second_ASP_EF_MVC.Infrastructure.Repositories.Base;

namespace Second_ASP_EF_MVC.Infrastructure.Repositories
{
    public class DepartmentRepository : Repository<Department> , IDepartmentRepository
    {

        private readonly AppDbContext _db;
        private readonly DbSet<Employee> _dbSet;
        public DepartmentRepository(AppDbContext db) : base(db) 
        {
            _db = db;
            _dbSet = _db.Set<Employee>();
        }

    }
}
