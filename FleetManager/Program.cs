using BusinessLogic.Services;
using DataRepo.Implementation;
using DataRepo.Interfaces;
using DataRepo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FleetDbContext>(options =>
    {

        options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=model;Trusted_Connection=True; TrustServerCertificate=True;",b=>b.MigrationsAssembly("FleetManager"));
    });

builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();

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
