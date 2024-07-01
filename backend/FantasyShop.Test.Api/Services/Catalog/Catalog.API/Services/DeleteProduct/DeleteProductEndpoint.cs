using Carter;
using Mapster;
using MediatR;

namespace Catalog.API.Services.DeleteProduct;

public record DeleteProductRequest(Guid Id);
public record DeleteProductResponse(bool IsSuccess);

public class DeleteProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapDelete("/products/{id}", async ([AsParameters] DeleteProductRequest request, ISender sender) =>
        {
            var query = request.Adapt<DeleteProductQuery>();

            var result = await sender.Send(query);

            var response = result.Adapt<DeleteProductResponse>();

            return Results.Ok(response);
        });
    }
}
