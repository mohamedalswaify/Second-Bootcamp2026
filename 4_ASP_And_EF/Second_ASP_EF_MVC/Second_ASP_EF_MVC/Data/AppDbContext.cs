using Microsoft.EntityFrameworkCore;
using Second_ASP_EF_MVC.Models;


namespace Second_ASP_EF_MVC.Data
{
    public class AppDbContext :DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }


        public DbSet<Employee> Employees { get; set; } 



    }
}
