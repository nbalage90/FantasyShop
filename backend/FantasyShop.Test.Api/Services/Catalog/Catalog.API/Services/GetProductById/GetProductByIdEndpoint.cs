using Carter;
using Catalog.API.Services.GetProducts;
using Catalop.API.Models;
using Mapster;
using MediatR;

namespace Catalog.API.Services.GetProductById;

public record GetProductByIdRequest(Guid Id);
public record GetProductByIdResponse(ProductDto Product);

public class GetProductByIdEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products/{id}", async ([AsParameters] GetProductByIdRequest request, ISender sender) =>
        {
            var query = request.Adapt<GetProductByIdQuery>();

            var result = await sender.Send(query);

            var response = result.Adapt<GetProductByIdResponse>();

            return Results.Ok(response);
        })
        .WithName("GetProductById")
        .Produces<GetProductsResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Returns a list of products")
        .WithSummary("Returns a list of paged products");
    }
}
