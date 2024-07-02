using Carter;
using Catalog.API.Services.GetProducts;
using Catalop.API.Models;
using Mapster;
using MediatR;

namespace Catalog.API.Services.GetProductsByCategory;

public record GetProductsByCategoryRequest(string Category);
public record GetProductsByCategoryResponse(IEnumerable<ProductDto> Products);

public class GetProductsByCategoryEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products/category/{category}", async ([AsParameters] GetProductsByCategoryRequest request, ISender sender) =>
        {
            var query = request.Adapt<GetProductsByCategoryQuery>();

            var result = await sender.Send(query);

            var response = result.Adapt<GetProductsByCategoryResponse>();

            return Results.Ok(response);
        })
        .WithName("GetProductsByCategory")
        .Produces<GetProductsResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Returns the Products of a category")
        .WithSummary("Returns the Products of a category");
    }
}
