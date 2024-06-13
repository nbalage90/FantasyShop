using BuildingBlocks.Models;
using Carter;
using Catalop.API.Models;
using Catalop.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalop.API.Services;

public class GetProductById(IRepository<Product> repository) : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products/{id}", async (Guid id) =>
        {
            var product = await repository.GetByIdAsync(id);

            if (product == null)
                return Results.NotFound(new Error
                {
                    Title = "Not Found",
                    Message = "Could not find the product with the given product id.",
                    Path = $"/products/{id}"
                });

            return Results.Ok(product);
        });
    }
}
