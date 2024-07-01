using Carter;
using Catalop.API.Models;
using Mapster;
using MediatR;

namespace Catalog.API.Services.GetProducts;

public record GetProductsRequest(int? PageSize = 10, int? PageNumber = 1);
public record GetProductsResponse(IEnumerable<ProductDto> Products);

public class GetProductsEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products", async ([AsParameters] GetProductsRequest request, ISender sender) =>
        {
            var query = request.Adapt<GetProductsQuery>();

            var response = await sender.Send(query);

            var products = response.Adapt<GetProductsResponse>();

            return Results.Ok(products);
        })
        .WithName("AddRoutes")
        .Produces<GetProductsResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Returns a list of products")
        .WithSummary("Returns a list of paged products");
    }
}
