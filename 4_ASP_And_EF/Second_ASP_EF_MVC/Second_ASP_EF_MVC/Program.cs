using Microsoft.EntityFrameworkCore;
using Second_ASP_EF_MVC.Application.Services;
using Second_ASP_EF_MVC.Application.Services.Base;
using Second_ASP_EF_MVC.Infrastructure.Data;
using Second_ASP_EF_MVC.Infrastructure.Repositories;
using Second_ASP_EF_MVC.Infrastructure.Repositories.Base;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var conectionString = builder.Configuration.GetConnectionString("DefaultDatabase");

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(conectionString));


builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<IEmployeeService, EmployeeService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Accounts}/{action=Login}/{id?}");

app.Run();
