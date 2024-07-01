using Carter;
using Catalog.Data;
using Catalog.Data.Seed;
using Catalop.API.Models;
using Catalop.API.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

var assembly = typeof(Program).Assembly;
builder.Services.AddDbContext<ProductDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerContainer"));
}, ServiceLifetime.Singleton);
builder.Services.AddSingleton<IRepository<ProductDto>, ProductRepository>();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
});
builder.Services.AddCarter();

var app = builder.Build();

app.UseCors(options =>
{
    options.WithOrigins("http://localhost:8000")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowAnyOrigin();
});
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/product")),
    RequestPath = "/Images"
});

if (app.Environment.IsDevelopment())
{
    await DataSeeder.InitializeDatabaseAsync(app);
}

app.MapCarter();

app.Run();
