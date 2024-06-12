using Carter;
using Catalop.API.Models;
using Catalop.API.Repositories;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddSingleton<IRepository<Product>, ProductRepository>();
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

app.MapCarter();

app.Run();
