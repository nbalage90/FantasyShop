using Carter;
using Catalop.API.Models;
using Catalop.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalop.API.Services;

public class GetProducts : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products", async (IRepository<ProductDto> repository, [FromQuery(Name = "count")] int? count) =>
        {
            var products = await repository.GetAsync(count);
            return Results.Ok(products);
        })
        .WithName("AddRoutes");
    }
}
