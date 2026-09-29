
using Second_ASP_EF_MVC.Domain.Models;
using Second_ASP_EF_MVC.Infrastructure.Repositories.Base;


namespace Second_ASP_EF_MVC.Infrastructure.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category? GetByUId(string uid);

    }
}
