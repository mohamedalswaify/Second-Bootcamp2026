using Microsoft.EntityFrameworkCore;
using Second_ASP_EF_MVC.Application.Services;
using Second_ASP_EF_MVC.Application.Services.Base;
using Second_ASP_EF_MVC.Infrastructure.Data;
using Second_ASP_EF_MVC.Infrastructure.Repositories.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conectionString = builder.Configuration.GetConnectionString("DefaultDatabase");

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(conectionString));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IEmployeeService, EmployeeService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
