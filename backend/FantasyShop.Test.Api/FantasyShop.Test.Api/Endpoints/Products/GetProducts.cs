using Carter;
using FantasyShop.Test.Api.Models;
using FantasyShop.Test.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FantasyShop.Test.Api.Endpoints.Products;

public class GetProducts(IRepository<Product> repository) : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products", async ([FromQuery(Name = "count")] int? count) =>
        {
            return Results.Ok(repository.Get(count));
        });
    }
}
