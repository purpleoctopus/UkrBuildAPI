using UkrBuildAPI.Services.Implementation;
using UkrBuildAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalhost",
    builder =>
    {
        builder.WithOrigins("https://localhost:6666/")
               .AllowAnyHeader()
               .AllowAnyMethod()
               .AllowCredentials();
    });
});

//Add other services

builder.Services.AddScoped<IDataService, DataService>();

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

app.UseCors("AllowLocalhost");

app.Run();