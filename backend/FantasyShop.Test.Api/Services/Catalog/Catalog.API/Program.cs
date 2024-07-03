using BuildingBlocks.Behaviors;
using BuildingBlocks.Exceptions.Handler;
using Catalog.Data.Seed;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddExceptionHandler<CustomExceptionHandler>();

var assembly = typeof(Program).Assembly;
builder.Services.AddDbContext<ProductDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerContainer"));
}, ServiceLifetime.Singleton);
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
    config.AddOpenBehavior(typeof(ValidationBehavior<,>));
});
builder.Services.AddCarter();

var app = builder.Build();

app.UseExceptionHandler(_ => { });

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
