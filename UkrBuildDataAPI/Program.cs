using Microsoft.EntityFrameworkCore;
using UkrBuildAPI.Shared.Models.Domain;
using UkrBuildDataAPI.Data;
using UkrBuildDataAPI.Data.Repository.Implementation;
using UkrBuildDataAPI.Data.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

/** 
 * Add services to the container
*/

builder.Services.AddDbContext<PostgreContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreConnectionString"));
});

//Add other services

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IPostgreStateRepository, PostgreStateRepository>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(options => {
    options.AllowAnyHeader();
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
});

/*using(var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider.GetRequiredService<IEmployeeRepository>();
    await service.AddEmployee(new Employee());
*/

app.Run();
