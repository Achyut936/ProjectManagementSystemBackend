using DomainLayer.Data;
using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.IRepo;
using RepositoryLayer.Repo;
using ServiceLayer.IService;
using ServiceLayer.Service;


var builder = WebApplication.CreateBuilder(args);
var ConnectionString = builder.Configuration.GetConnectionString("MyDatabaseConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(ConnectionString));
// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Service Injected
builder.Services.AddScoped(typeof(ITableProjectsRepo<>), typeof(TableProjectsRepo<>));

builder.Services.AddScoped<ITableProjectsService<TableProjects>, TableProjectsService>();



#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
