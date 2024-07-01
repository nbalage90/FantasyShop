using Carter;
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
        });
    }
}
