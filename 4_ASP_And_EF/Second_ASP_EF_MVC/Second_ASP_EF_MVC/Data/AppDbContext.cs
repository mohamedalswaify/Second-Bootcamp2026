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
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Department> Departments { get; set; }  

        public DbSet<Product> Products { get; set; }


        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<PermissionRole> PermissionRoles { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PermissionRole>()
                .HasKey(pr => new
                {
                    pr.RolesId,
                    pr.PemissionsId
                });

        }



        }
}
