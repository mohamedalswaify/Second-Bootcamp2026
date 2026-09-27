using Microsoft.EntityFrameworkCore;
using Second_ASP_EF_MVC.Data;
using Second_ASP_EF_MVC.Models;
using Second_ASP_EF_MVC.Repositories.Base;

namespace Second_ASP_EF_MVC.Repositories
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
