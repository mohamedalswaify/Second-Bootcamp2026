using Microsoft.EntityFrameworkCore;
using Second_ASP_EF_MVC.Infrastructure.Data;
using Second_ASP_EF_MVC.Domain.Models;
using Second_ASP_EF_MVC.Infrastructure.Repositories.Base;

namespace Second_ASP_EF_MVC.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository 
    {

        private readonly AppDbContext _db;
        private readonly DbSet<Category> _dbSet;
        public CategoryRepository(AppDbContext db) :base(db) 
        {
            _db = db;
            _dbSet = _db.Set<Category>();
        }

        public Category? GetByUId(string uid)
        {
            return _dbSet.FirstOrDefault(e=>e.UID == uid);  
        }

      
    }
}
