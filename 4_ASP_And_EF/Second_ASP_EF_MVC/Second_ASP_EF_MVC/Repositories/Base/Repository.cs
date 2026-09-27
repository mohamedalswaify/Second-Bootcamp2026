using Microsoft.EntityFrameworkCore;
using Second_ASP_EF_MVC.Data;
using Second_ASP_EF_MVC.Models;

namespace Second_ASP_EF_MVC.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly AppDbContext _db;
        private readonly DbSet<T> _dbSet;
        public Repository(AppDbContext db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
            //-------------
        }

        public void Add(T employee)
        {
            _dbSet.Add(employee);
        }

        public void Delete(T employee)
        {
            _dbSet.Remove(employee);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Save()
        {
            _db.SaveChanges();
        }



        public void Update(T employee)
        {
            _dbSet.Update(employee);
        }
    }
}
