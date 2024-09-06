using Microsoft.EntityFrameworkCore;
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

app.Run();
